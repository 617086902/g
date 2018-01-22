using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessService.Entities;
using GuModel;
using Core;

namespace BusinessService
{
    public class LikeService : ILikeService
    {
        private GSEntities dbcontext;
        public LikeService()
        {
            dbcontext = AppContext.Current.DbContext;
        }

        public UserPostModel GetLikePostList(int userId, int pageIndex, int pageSize)
        {
            IEnumerable<UserPost> userPost = from l in dbcontext.UserLike
                                             join p in dbcontext.Post on l.TargetId equals p.Id
                                             join s in dbcontext.Stock on p.StockCode equals s.StockCode
                                             where l.CreatedBy == userId && l.TargetType == 1 && !l.Deleted
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

        public bool IsLike(int targetId, TargetType targetType)
        {
            int type = (int)targetType;
            var res = dbcontext.UserLike.Any(l => l.TargetId == targetId && l.TargetType == type && l.CreatedBy == AppContext.Current.CurrentUser.User.Id && l.Deleted == false);
            return res;
        }

        public bool LikeOrUnLike(int targetId, TargetType targetType, bool isLike)
        {
            if (AppContext.Current.CurrentUser == null) return false;
            int userid = AppContext.Current.CurrentUser.User.Id;
            int type = (int)targetType;
            UserLike like;
            if (!dbcontext.UserLike.Any(l => l.TargetId == targetId && l.TargetType == type && l.CreatedBy == userid))
            {
                like = new UserLike()
                {
                    TargetId = targetId,
                    TargetType = (int)targetType,
                    CreatedBy = userid,
                    CreatedOn = DateTime.Now,
                    Deleted = !isLike
                };
                dbcontext.UserLike.Add(like);
            }
            else
            {
                like = dbcontext.UserLike.FirstOrDefault(l => l.TargetId == targetId && l.TargetType == type && l.CreatedBy == userid);
                if (like == null) return false;
                like.Deleted = !isLike;
            }
            return dbcontext.SaveChanges() > 0;
        }
    }
}
