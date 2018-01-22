using Core;
using Core.Entities;
using GuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService
{
    public class ScoreService
    {
        private GSEntities dbcontext;
        public int SendPostScore = 2;
        public int ReplyCommentScore = 2;
        public int[] RewardComment = { 3000, 1000, 500, 200, 50, 1 };
        public int[] RewardScore = { 3, 2, 1, 1, 1 };
        public ScoreService()
        {
            dbcontext = AppContext.Current.DbContext;
        }
        /// <summary>
        /// 发帖奖励积分
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="stockCode"></param>
        public void SendPostAddScore(int userId, string stockCode)
        {
            var postList = dbcontext.Post.Where(p => p.CreatedBy == userId && p.StockCode == stockCode).OrderByDescending(i => i.Id).Take(10);
            var today = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            if (postList.Count(p => p.CreatedOn > today) >= 10) return;
            AddScore(userId, SendPostScore);
            dbcontext.SaveChanges();
            UpdateLevelScore();
        }

        /// <summary>
        /// 回帖
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="stockCode"></param>
        public void SendCommentAddScore(int userId, int postId)
        {
            var isCommented = dbcontext.Comment.Any(c => c.CreatedBy == userId && c.PostId == postId);
            //回复者加积分
            if (!isCommented)
            {
                AddScore(userId, ReplyCommentScore);
            }
            //发帖者加积分
            var commentCount = dbcontext.Comment.Count(p => p.PostId == postId);
            if (AppContext.Current.CurrentUser.User.Id != userId && commentCount < RewardComment[0])
            {
                for (int i = 0; i < RewardComment.Length; i++)
                {
                    if (commentCount < RewardComment[i]) continue;
                    else
                    {
                        var post = dbcontext.Post.FirstOrDefault(p => p.Id == postId);
                        Random rd = new Random();
                        int score = rd.Next(RewardScore[i], RewardScore[i - 1]);
                        AddScore(post.CreatedBy, score);
                        break;
                    }
                }
            }
            dbcontext.SaveChanges();
            UpdateLevelScore();
        }

        /// <summary>
        /// 增加积分
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="score"></param>
        public void AddScore(int userId, int score)
        {
            var uaccount = dbcontext.UserAccount.FirstOrDefault(a => a.CreatedBy == userId);
            uaccount.ScoreValue += score;
            var userLevel = dbcontext.UserLevel.FirstOrDefault(l => l.LevelNum == uaccount.UserLevel);
            if (uaccount.ScoreValue >= userLevel.LevelScore) uaccount.UserLevel++;
        }

        public void UpdateLevelScore()
        {
            int curUserId = AppContext.Current.CurrentUser.User.Id;
            var scoreLevel = (from a in dbcontext.UserAccount
                              join l in dbcontext.UserLevel on a.UserLevel equals l.LevelNum
                              where a.CreatedBy == curUserId
                              select new ScoreLevel
                              {
                                  UserScore = a.ScoreValue,
                                  LevelName = l.LevelName,
                                  LevelScore = l.LevelScore,
                                  UserLevel = a.UserLevel,
                              }).FirstOrDefault();
            scoreLevel.NextLevelScore = dbcontext.UserLevel.FirstOrDefault(u => u.LevelNum == scoreLevel.UserLevel + 1).LevelScore;
            AppContext.Current.CurrentUser.ScoreLevel.UserScore = scoreLevel.UserScore;
            AppContext.Current.CurrentUser.ScoreLevel.LevelName = scoreLevel.LevelName;
            AppContext.Current.CurrentUser.ScoreLevel.UserLevel = scoreLevel.UserLevel;
            AppContext.Current.CurrentUser.ScoreLevel.LevelScore = scoreLevel.LevelScore;
            AppContext.Current.CurrentUser.ScoreLevel.NextLevelScore = scoreLevel.NextLevelScore;
        }
    }
}
