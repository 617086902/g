using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuModel;
using Core;
using Core.Utilities;
using Core.Entities;

namespace BusinessService
{
    public class UserService : IUserService
    {
        private GSEntities dbcontext;

        public UserService()
        {
            dbcontext = AppContext.Current.DbContext;
        }

        BaseUser IUserService.Login(string usercode, string passcode)
        {
            User user = dbcontext.User.FirstOrDefault(u => u.Mobile.Equals(usercode)
                    || u.Email.Equals(usercode) || u.UserCode.Equals(usercode));
            if (user == null) return null;
            bool loginSuccess = user.PassCode.Equals(MD5Helper.GetMD5(passcode));
            BaseUser baseUser = new BaseUser();
            if (loginSuccess)
            {
                baseUser.User = user;
                UserInformation uinfo = dbcontext.UserInformation.FirstOrDefault(i => i.UserId == user.Id);
                uinfo.LastLoginTime = DateTime.Now;
                baseUser.UserInformation = uinfo;
                dbcontext.SaveChanges();
                var scoreLevel = (from a in dbcontext.UserAccount
                                  join l in dbcontext.UserLevel on a.UserLevel equals l.LevelNum
                                  where a.CreatedBy == user.Id
                                  select new ScoreLevel
                                  {
                                      UserScore = a.ScoreValue,
                                      LevelName = l.LevelName,
                                      LevelScore = l.LevelScore,
                                      UserLevel = a.UserLevel,
                                  }).FirstOrDefault();
                scoreLevel.NextLevelScore = dbcontext.UserLevel.FirstOrDefault(u => u.LevelNum == scoreLevel.UserLevel + 1).LevelScore;
                baseUser.ScoreLevel = scoreLevel;
            }
            return loginSuccess ? baseUser : null;
        }

        public bool CheckIsRegisted(string usercode)
        {
            return dbcontext.User.Any(u => (u.Mobile.Equals(usercode) || u.Email.Equals(usercode)) && !u.Deleted);
        }


        public bool RegistUser(BaseUser user)
        {
            if (user.User == null
                || (string.IsNullOrWhiteSpace(user.User.Mobile) && string.IsNullOrWhiteSpace(user.User.Email)
                    && string.IsNullOrWhiteSpace(user.User.UserCode))
                || string.IsNullOrWhiteSpace(user.User.PassCode)
                || string.IsNullOrWhiteSpace(user.UserInformation.Nickname)) return false;
            System.Data.Common.DbConnection con =
                ((System.Data.Entity.Infrastructure.IObjectContextAdapter)dbcontext).ObjectContext.Connection;
            con.Open();
            using (var tran = con.BeginTransaction())
            {
                try
                {
                    user.User.CreatedOn = DateTime.Now;
                    user.User.PassCode = MD5Helper.GetMD5(user.User.PassCode);
                    user.User.Deleted = false;
                    dbcontext.User.Add(user.User);
                    bool isSuccess = dbcontext.SaveChanges() > 0;
                    if (isSuccess)
                    {
                        string[] profilephoto = { "/content/img/niu.png", "/content/img/xiong.png" };
                        string prifilePhoto = string.IsNullOrEmpty(user.UserInformation.ProfilePhoto)
                            ? profilephoto[new Random().Next(0, 1)] : user.UserInformation.ProfilePhoto;
                        UserInformation uinfo = new UserInformation
                        {
                            UserId = user.User.Id,
                            Nickname = user.UserInformation.Nickname,
                            ProfilePhoto = prifilePhoto,
                            CreatedOn = DateTime.Now,
                            CreatedBy = user.User.Id,
                            Deleted = false,
                        };
                        dbcontext.UserInformation.Add(uinfo);
                        UserAccount ua = new UserAccount
                        {
                            UserLevel = 1,
                            MoneyValue = 0.00m,
                            ScoreValue = 0.00m,
                            CreatedBy = user.User.Id,
                            CreatedOn = DateTime.Now,
                            Deleted = false
                        };
                        dbcontext.UserAccount.Add(ua);
                        isSuccess = dbcontext.SaveChanges() > 0;
                    }
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    con.Close();
                    return false;
                }
                con.Close();
                return true;
            }
        }

        /// <summary>
        /// 添加第三方账号
        /// </summary>
        /// <param name="thirdPartyAccount"></param>
        /// <returns></returns>
        public bool AddThirdPartyAccount(ThirdPartyAccount thirdPartyAccount)
        {
            thirdPartyAccount.AuthDate = DateTime.Now;
            thirdPartyAccount.Deleted = false;
            dbcontext.ThirdPartyAccount.Add(thirdPartyAccount);
            return dbcontext.SaveChanges() > 0;
        }

        public ThirdPartyAccount GetThirdpartyAccount(string openId)
        {
            return dbcontext.ThirdPartyAccount.FirstOrDefault(t => t.OpenId == openId);
        }

        public bool LoginOut(string usercode)
        {
            throw new NotImplementedException();
        }

        public bool EditProfile(UserInformation info)
        {
            var uinfo = dbcontext.UserInformation.FirstOrDefault(u => u.Id == info.Id);
            uinfo.ProfilePhoto = info.ProfilePhoto;
            return dbcontext.SaveChanges() > 0;
        }

        public string GetUserCodeById(int userId)
        {
            var user = dbcontext.User.FirstOrDefault(u => u.Id == userId);
            return user == null ? "" : user.UserCode;
        }
    }
}
