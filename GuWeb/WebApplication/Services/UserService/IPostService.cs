using BusinessService.Entities;
using GuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService
{
    public interface IPostService
    {
        /// <summary>
        /// 添加帖子
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        bool Add(Post post);

        /// <summary>
        /// 根据股票代码获取帖子
        /// </summary>
        /// <param name="stockCode"></param>
        /// <returns></returns>
        PostListModel GetPostByStockCode(string stockCode, int pageIndex, int pageSize);

        /// <summary>
        /// 根据股票代码获取帖子，带分页
        /// </summary>
        /// <param name="stockCode"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        PostListModel GetPostData(string stockCode, int pageIndex, int pageSize);

        /// <summary>
        /// 获取帖子详情
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        PostDetial GetPostDetialsById(int postId);

        /// <summary>
        /// 添加评论
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>
        bool AddComment(Comment comment);

        /// <summary>
        /// 获取评论
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        CommentListModel GetPostComment(int postId, int pageIndex, int pageSize);


        /// <summary>
        /// 获取评论，带分页
        /// </summary>
        /// <param name="postId"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        CommentListModel GetCommentByPostId(int postId, int pageIndex, int pageSize);

        /// <summary>
        /// 获取新评论的楼层
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        int GetNextCommentFloor(int pid);

        /// <summary>
        /// 获取热门帖子
        /// </summary>
        /// <param name="topN"></param>
        /// <param name="stockCode"></param>
        /// <returns></returns>
        List<HotPost> GetHotPost(int topN, string stockCode = "");

        /// <summary>
        /// 获取用户发帖数量
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        int GetUserPostCount(int userId);

        /// <summary>
        /// 获取用户收藏帖子数量
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        int GetUserLikePostCount(int userId);

        /// <summary>
        /// 获取用户发的帖子
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        UserPostModel GetUserPost(int userId, int pageIndex,int pageSize);
    }
}
