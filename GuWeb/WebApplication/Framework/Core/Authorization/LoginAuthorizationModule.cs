using Core.Entities;
using Core.Utilities;
using GuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Core.Authorization
{
    public class LoginAuthorizationModule : IHttpModule
    {
        public void Dispose() { }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="context"></param>
        public void Init(HttpApplication context)
        {
            //context.PostAcquireRequestState += context_PostAcquireRequestState;
            context.PreRequestHandlerExecute += context_PostAcquireRequestState;
        }

        /// <summary>
        /// 获取完会话状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void context_PostAcquireRequestState(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            //静态文件直接返回
            if (application.Request.RequestContext.RouteData.Route == null) return;
            //如果会话当中保存了用户状态，则不需要继续后续校验步骤
            if (AppContext.Current.CurrentUser != null) return;
            //自动登陆
            if (AutoLogin(application)) return;
            //判断当前url是否能忽略校验
            if (this.CanIgnoreVerify(application)) return;
            //是否要跳转到登录页
            string loginUrl;
            if (this.IsNeedRedirectToLoginpage(application, out loginUrl))
            {
                application.Response.Redirect(loginUrl);
                return;
            }
        }

        /// <summary>
        /// 是否需要跳转到登陆页面
        /// 可在此处做是否微信登陆判断
        /// </summary>
        /// <param name="application"></param>
        /// <param name="loginUrl"></param>
        /// <returns></returns>
        private bool IsNeedRedirectToLoginpage(HttpApplication application, out string loginUrl)
        {
            loginUrl = string.Format("{0}?redirectURL={1}", "/user/login",
                HttpUtility.UrlEncode(application.Request.Url.ToString()));
            return ConfigHelper.Get(AppSettingsKey.IsNeedRedirectToLoginpage) == "true";
            //非微信浏览器登录，跳转到登陆页面
            //string userAgent = application.Request.UserAgent;
            //string weixinAgent = "micromessenger";
            //bool isWeixinBrowser = userAgent.ToLower().Contains(weixinAgent);
            //return !isWeixinBrowser;
        }

        /// <summary>
        /// 是否可以跳过验证
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        private bool CanIgnoreVerify(HttpApplication application)
        {
            if (application.Request.Url.ToString().EndsWith("ashx")) return true;
            string routeController = (string)(application.Request.RequestContext.RouteData.Values["controller"] ?? "");
            string routeAction = (string)(application.Request.RequestContext.RouteData.Values["action"] ?? "");
            List<string> ignoreList = new List<string> {
                "user/index"
            };
            bool cannotIgnore = ignoreList.Contains(routeController.ToLower() + "/" + routeAction.ToLower());
            return !cannotIgnore;
        }

        /// <summary>
        /// 自动登陆
        /// </summary>
        private bool AutoLogin(HttpApplication application)
        {
            try
            {
                if (application.Request.Cookies["login"] != null)
                {
                    string[] values = application.Request.Cookies["login"].Value.Split('|');
                    var dbcontext = AppContext.Current.DbContext;
                    string userCode = values[0];
                    User user = dbcontext.User.FirstOrDefault(u => u.Mobile.Equals(userCode)
                                    || u.Email.Equals(userCode)
                                    || u.UserCode.Equals(userCode));
                    if (user == null) return false;
                    bool loginSuccess = user.PassCode.Equals(values[1]);
                    BaseUser baseUser = new BaseUser();
                    if (loginSuccess)
                    {
                        baseUser.User = user;
                        UserInformation uinfo = dbcontext.UserInformation.FirstOrDefault(i => i.UserId == user.Id);
                        baseUser.UserInformation = uinfo;
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
                        application.Session[SessionKey.CurrentUser] = baseUser;
                        return true;
                    }
                    else
                    {
                        application.Response.Cookies["login"].Expires = DateTime.Now.AddDays(-1);
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
