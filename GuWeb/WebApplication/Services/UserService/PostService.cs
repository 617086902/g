using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuModel;
using Core;
using BusinessService.Entities;
using Core.Utilities;
using System.Text.RegularExpressions;

namespace BusinessService
{
    public class PostService : IPostService
    {
        private GSEntities dbcontext;
        public PostService()
        {
            dbcontext = AppContext.Current.DbContext;
        }

        #region 帖子相关
        public bool Add(Post post)
        {
            ScoreService scoreService = new ScoreService();
            scoreService.SendPostAddScore(post.CreatedBy, post.StockCode);
            dbcontext.Post.Add(post);
            return dbcontext.SaveChanges() > 0;
        }

        public PostListModel GetPostData(string stockCode, int pageIndex, int pageSize)
        {
            PostListModel pm = new PostListModel();
            var count = dbcontext.Post.Count(p => p.StockCode == stockCode && !p.Deleted);
            int skipcount = (pageIndex - 1) * pageSize;
            var postList = (from p in dbcontext.Post
                            join i in dbcontext.UserInformation on p.CreatedBy equals i.UserId
                            //join s in dbcontext.Stock on p.StockCode equals s.StockCode
                            where p.StockCode == stockCode && !p.Deleted
                            select new PostDetial
                            {
                                Post = p,
                                //StockName = s.StockName,
                                UserName = i.Nickname,
                                ProfilePhoto = i.ProfilePhoto
                            }).OrderByDescending(s => s.Post.ModifyOn).Skip(skipcount).Take(pageSize);
            pm.PostData = postList.ToList();
            pm.DataCount = count;
            return pm;
        }
        public PostListModel GetPostByStockCode(string stockCode, int pageIndex, int pageSize)
        {
            var pm = GetPostData(stockCode, pageIndex, pageSize);
            pm.PageIndex = pageIndex;
            pm.PageSize = pageSize;
            pm.PageCount = (int)Math.Ceiling(pm.DataCount * 1.00 / pageSize);
            Regex reg = new Regex(@"<([^>]*)>");
            foreach (var p in pm.PostData)
            {
                p.Post.Content = reg.Replace(p.Post.Content, "");
                p.CommontCount = dbcontext.Comment.Count(c => c.PostId == p.Post.Id && !c.Deleted && c.ParentCommentId == 0);
                p.Post.Content = p.Post.Content.Length > 100 ? p.Post.Content.Substring(0, 100) : p.Post.Content;
                p.ShowTime = ShowTimeHelper.ConvertToShowTime(p.Post.CreatedOn);
            }
            return pm;
        }



        public PostDetial GetPostDetialsById(int postId)
        {
            var postdetials = (from p in dbcontext.Post
                               join i in dbcontext.UserInformation on p.CreatedBy equals i.UserId
                               join s in dbcontext.Stock on p.StockCode equals s.StockCode
                               join a in dbcontext.UserAccount on p.CreatedBy equals a.CreatedBy
                               join l in dbcontext.UserLevel on a.UserLevel equals l.LevelNum
                               where p.Id == postId && !p.Deleted
                               select new PostDetial
                               {
                                   Post = p,
                                   StockName = s.StockName,
                                   UserName = i.Nickname,
                                   ProfilePhoto = i.ProfilePhoto,
                                   LevelName = l.LevelName,
                                   UserLevel = a.UserLevel
                               }).FirstOrDefault();
            if (postdetials == null) return null;
            postdetials.ShowTime = ShowTimeHelper.ConvertToShowTime(postdetials.Post.CreatedOn);
            return postdetials;
        }
        #endregion


        #region 评论相关

        public bool AddComment(Comment comment)
        {
            ScoreService scoreService = new ScoreService();
            scoreService.SendCommentAddScore(comment.CreatedBy, comment.PostId);
            if (comment.ParentCommentId == default(int))
                comment.Floor = GetNextCommentFloor(comment.PostId);
            dbcontext.Comment.Add(comment);
            UpdatePost(comment.PostId, comment.CreatedBy);
            return dbcontext.SaveChanges() > 0;
        }
        //更新帖子最后更新时间
        private void UpdatePost(int pid, int modifyBy)
        {
            var post = dbcontext.Post.FirstOrDefault(p => p.Id == pid);
            post.ModifyOn = DateTime.Now;
            post.ModifyBy = modifyBy;
            post.HotValue = post.HotValue + 10;
        }

        public CommentListModel GetPostComment(int postId, int pageIndex, int pageSize)
        {
            CommentListModel cm = new CommentListModel();
            int count = dbcontext.Comment.Count(c => c.PostId == postId && !c.Deleted && c.ParentCommentId == 0);
            var commentList = from c in dbcontext.Comment
                              join i in dbcontext.UserInformation on c.CreatedBy equals i.UserId
                              where c.PostId == postId && !c.Deleted && c.ParentCommentId == 0
                              select new CommentDetials
                              {
                                  UserName = i.Nickname,
                                  Comment = c,
                                  ProfilePhoto = i.ProfilePhoto
                              };
            cm.CommentData = commentList.OrderBy(c => c.Comment.Id).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            cm.DataCount = count;
            return cm;
        }
        public CommentListModel GetCommentByPostId(int postId, int pageIndex, int pageSize)
        {
            CommentListModel cm = GetPostComment(postId, pageIndex, pageSize);
            cm.PageIndex = pageIndex;
            cm.PageSize = pageSize;
            cm.PageCount = (int)Math.Ceiling(cm.DataCount * 1.00 / pageSize);
            foreach (var c in cm.CommentData)
            {
                c.CommentReply = (from r in dbcontext.Comment
                                  join u in dbcontext.UserInformation on r.CreatedBy equals u.UserId
                                  where r.ParentCommentId == c.Comment.Id && !r.Deleted
                                  select new CommentDetials
                                  {
                                      UserName = u.Nickname,
                                      Comment = r
                                  }).ToList();

                foreach (var r in c.CommentReply)
                    r.CreatedDate = ShowTimeHelper.ConvertToShowTime(r.Comment.CreatedOn);
                c.CreatedDate = ShowTimeHelper.ConvertToShowTime(c.Comment.CreatedOn);

                var score = (from a in dbcontext.UserAccount
                             join l in dbcontext.UserLevel on a.UserLevel equals l.LevelNum
                             where a.CreatedBy == c.Comment.CreatedBy
                             select new
                             {
                                 LevelName = l.LevelName,
                                 UserLevel = a.UserLevel
                             }).FirstOrDefault();
                c.LevelName = score.LevelName;
                c.UserLevel = score.UserLevel;
            }
            return cm;
        }

        public int GetNextCommentFloor(int pid)
        {
            return dbcontext.Comment.Count(c => c.PostId == pid && c.ParentCommentId == 0) + 1;
        }

        public List<HotPost> GetHotPost(int topN, string stockCode = "")
        {
            var hotlist = stockCode == "" ? dbcontext.Post.Where(p => !p.Deleted) :
                dbcontext.Post.Where(p => p.StockCode == stockCode && !p.Deleted);
            if (hotlist == null || !hotlist.Any()) return null;
            hotlist = hotlist.OrderByDescending(s => s.HotValue).Take(topN);
            var res = from p in hotlist
                      join s in dbcontext.Stock on p.StockCode equals s.StockCode
                      join i in dbcontext.UserInformation on p.CreatedBy equals i.UserId
                      select new HotPost
                      {
                          UserName = i.Nickname,
                          PostId = p.Id,
                          GubaName = s.StockName,
                          HotValue = p.HotValue,
                          PostTitle = p.Title,
                          StockCode = p.StockCode
                      };
            return res.OrderByDescending(s => s.HotValue).ToList();
        }

        public int GetUserPostCount(int userId)
        {
            return dbcontext.Post.Count(p => p.CreatedBy == userId);
        }
        public int GetUserLikePostCount(int userId)
        {
            return dbcontext.UserLike.Count(p => p.CreatedBy == userId && p.TargetType == 1 && !p.Deleted);
        }

        public UserPostModel GetUserPost(int userId, int pageIndex, int pageSize)
        {
            IEnumerable<UserPost> userPost = from p in dbcontext.Post
                                             join s in dbcontext.Stock on p.StockCode equals s.StockCode
                                             where p.CreatedBy == userId
                                             select new UserPost
                                             {
                                                 PostId = p.Id,
                                                 PostTitle = p.Title,
                                                 CreatedDate = p.CreatedOn,
                                                 GubaName = s.StockName,
                                                 StockCode = p.StockCode,
                                                 CommentCount = 0,
                                             };
            UserPostModel um = new UserPostModel();
            um.DataCount = userPost.Count();
            um.PageIndex = pageIndex;
            um.PageSize = pageSize;
            um.PageCount = (int)Math.Ceiling(um.DataCount * 1.00 / pageSize);
            userPost = userPost.OrderByDescending(u => u.PostId).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            foreach (var post in userPost)
            {
                post.CommentCount = dbcontext.Comment.Count(c => c.PostId == post.PostId && !c.Deleted && c.ParentCommentId == 0);
                post.ShowDate = post.CreatedDate.ToString("yyyy-MM-dd HH:mm");
            }
            um.UserPost = userPost.ToList();
            return um;
        }
        #endregion
    }
}
