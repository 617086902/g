using BusinessService;
using CommonService.QQ;
using Core.Entities;
using Core.Utilities;
using GuModel;
using QConnectSDK;
using QConnectSDK.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace GS.Web.Controllers
{
    public class QQController : Controller
    {
        // GET: QQ
        public ActionResult Index()
        {
            return View();
        }

        [Description("获取qq登陆授权地址")]
        public JsonResult GetQLoginUrl()
        {
            return Json(new ResultData { code = ResultCode.ok, data = null }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Login(string returnUrl)
        {
            this.Session[SessionKey.ReturnURL] = returnUrl;
            var context = new QzoneContext();
            string state = Guid.NewGuid().ToString().Replace("-", "");
            Session[SessionKey.RequestState] = state;
            string scope = "get_user_info,add_share,list_album,upload_pic,check_page_fans,"
                + "add_t,add_pic_t,del_t,get_repost_list,get_info,get_other_info,get_fanslist,"
                + "get_idolist,add_idol,del_idol,add_one_blog,add_topic,get_tenpay_addr";
            var authenticationUrl = context.GetAuthorizationUrl(state, scope);
            return new RedirectResult(authenticationUrl);
        }
        public ActionResult CallBack()
        {
            if (Request.Params["code"] == null)
            {
                ViewBag.Tip = "授权失败";
                return View();
            }

            QOpenClient qzone = null;

            var verifier = Request.Params["code"];
            var state = Request.Params["state"];
            if (Session[SessionKey.RequestState] == null)
            {
                ViewBag.Tip = "授权异常";
                return View();
            }

            string requestState = Session[SessionKey.RequestState].ToString();

            if (state != requestState) return Redirect("/");

            qzone = new QOpenClient(verifier, state);
            if (qzone.OAuthToken.OpenId == null)
            {
                ViewBag.Tip = "获取用户失败";
                return View();
            }
            try
            {
                var currentUser = qzone.GetCurrentUser();
                QZoneUser quser = CommonApi.GetUserInfo(qzone.OAuthToken.AccessToken, ConfigHelper.Get("QQAppKey"), qzone.OAuthToken.OpenId);
                //调试用
                //ViewBag.Tip = Newtonsoft.Json.JsonConvert.SerializeObject(quser);
                //return View();
                if (this.Session["QzoneOauth"] == null)
                {
                    this.Session["QzoneOauth"] = qzone;
                }
                IUserService _userService = new UserService();

                ThirdPartyAccount thirdAccount = _userService.GetThirdpartyAccount(qzone.OAuthToken.OpenId);
                if (thirdAccount == null)
                {
                    BaseUser user = new BaseUser
                    {
                        User = new User
                        {
                            UserCode = RandomOperate.RandomName(7),
                            PassCode = DefaultData.PassCode,
                        },
                        UserInformation = new UserInformation
                        {
                            Nickname = currentUser.Nickname,
                            Gender = currentUser.Gender == "男" ? 1 : 0,
                            ProfilePhoto = quser.figureurl_qq_2
                        }
                    };
                    bool registSuccess = _userService.RegistUser(user);
                    if (registSuccess)
                    {
                        thirdAccount = new ThirdPartyAccount
                        {
                            OpenId = qzone.OAuthToken.OpenId,
                            UserId = user.User.Id,
                            AccountType = (int)ThirdpartyAccountType.QQ
                        };
                        bool isSuccess = _userService.AddThirdPartyAccount(thirdAccount);
                    }
                }
                string userCode = _userService.GetUserCodeById(thirdAccount.UserId);
                BaseUser loginUser = _userService.Login(userCode, DefaultData.PassCode);
                bool loginSuccess = loginUser != null;
                if (loginSuccess)
                {
                    FormsAuthentication.SetAuthCookie(userCode, true);
                    Session[SessionKey.CurrentUser] = loginUser;
                    Response.Cookies["login"].Value = userCode + "|" + MD5Helper.GetMD5(loginUser.User.PassCode);
                    Response.Cookies["login"].Expires = DateTime.Now.AddDays(30);
                }
                else
                {
                    ViewBag.Tip = "登陆失败";
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.Tip = ex.StackTrace;
                return View();
            }
            //SetAuthCookie(qzone.OAuthToken.OpenId, isPersistentCookie, friendlyName);
            if (Session[SessionKey.ReturnURL] != null)
                return Redirect(Session[SessionKey.ReturnURL].ToString());
            return Redirect("/user/");
        }
    }
}