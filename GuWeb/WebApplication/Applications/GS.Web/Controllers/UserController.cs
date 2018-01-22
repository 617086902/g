using BusinessService;
using CommonService.Sms;
using Core.Entities;
using Core.Utilities;
using GuModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace GS.Web.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        private IPostService _postService;
        public UserController() : this(new UserService(), new PostService()) { }
        public UserController(IUserService userServcie, IPostService postService)
        {
            _userService = userServcie;
            _postService = postService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [Description("注册页面")]
        public ActionResult Regist()
        {
            return View();
        }

        [Description("判断用户是否已注册")]
        public JsonResult CheckIsRegisted(string key)
        {
            bool isRegisted = _userService.CheckIsRegisted(key);
            return Json(new ResultData
            {
                code = isRegisted ? ResultCode.fail : ResultCode.ok,
                msg = isRegisted ? "该账号已注册" : "",
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Description("注册表单提交")]
        public JsonResult RegistUser(string username, string validUserAccount, string passcode)
        {
            if (!SessionHelper.Exist(SessionKey.ValidUserAccount))
                return Json(new ResultData { code = ResultCode.fail, msg = "请验证手机或邮箱", }, JsonRequestBehavior.AllowGet);
            string userCode = SessionHelper.GetSession(SessionKey.ValidUserAccount);
            if (userCode != validUserAccount)
                return Json(new ResultData { code = ResultCode.fail, msg = "请验证手机或邮箱", }, JsonRequestBehavior.AllowGet);
            BaseUser user = new BaseUser
            {
                User = new User
                {
                    PassCode = passcode,
                },
                UserInformation = new UserInformation
                {
                    Nickname = username,
                }
            };
            if (userCode.Contains('@')) user.User.Email = userCode;
            else user.User.Mobile = userCode;
            bool registSuccess = _userService.RegistUser(user);
            if (registSuccess)
            {
                SessionHelper.DeleteSession(SessionKey.ValidMobile);
                //自动登陆
                BaseUser loginUser = _userService.Login(userCode, passcode);
                bool loginSuccess = loginUser != null;
                if (loginSuccess)
                {
                    FormsAuthentication.SetAuthCookie(loginUser.User.Mobile, true);
                    Session[SessionKey.CurrentUser] = loginUser;
                }
                return Json(new ResultData { code = ResultCode.ok }, JsonRequestBehavior.AllowGet);
            }
            else
                return Json(new ResultData { code = ResultCode.fail, msg = "注册失败", }, JsonRequestBehavior.AllowGet);
        }


        [Description("登陆页面")]
        public ActionResult Login()
        {
            return View();
        }

        [Description("设置页面")]
        public ActionResult Setting()
        {
            return View();
        }


        [HttpPost]
        [Description("用户登陆")]
        public JsonResult UserLogin(string logincode, string passcode, bool rememberme, string imgCode = "")
        {
            if (!SessionHelper.Exist(SessionKey.ValidCode))
                return Json(new ResultData { code = ResultCode.fail, msg = "获取验证码失败", }, JsonRequestBehavior.AllowGet);
            if (!SessionHelper.GetSession(SessionKey.ValidCode).Equals(imgCode, StringComparison.InvariantCultureIgnoreCase))
                return Json(new ResultData { code = ResultCode.fail, msg = "验证码不正确", }, JsonRequestBehavior.AllowGet);
            BaseUser loginUser = _userService.Login(logincode, passcode);
            bool loginSuccess = loginUser != null;
            if (loginSuccess)
            {
                FormsAuthentication.SetAuthCookie(logincode, true);
                Session[SessionKey.CurrentUser] = loginUser;
                if (rememberme)
                {
                    Response.Cookies["login"].Value = logincode + "|" + MD5Helper.GetMD5(passcode);
                    Response.Cookies["login"].Expires = DateTime.Now.AddDays(30);
                }
            }
            return Json(new ResultData { code = loginSuccess ? ResultCode.ok : ResultCode.fail, msg = loginSuccess ? "" : "用户名或密码不正确" }, JsonRequestBehavior.DenyGet);
        }

        [HttpPost]
        [Description("登出")]
        public JsonResult LoginOut()
        {
            Session.Remove(SessionKey.CurrentUser);
            Response.Cookies["login"].Expires = DateTime.Now.AddDays(-1);
            return Json(new ResultData { code = ResultCode.ok }, JsonRequestBehavior.DenyGet);
        }

        [Description("获取用户发帖数量")]
        public JsonResult GetUserDataCount()
        {
            int postcount = _postService.GetUserPostCount(Core.AppContext.Current.CurrentUser.User.Id);
            int likecount = _postService.GetUserLikePostCount(Core.AppContext.Current.CurrentUser.User.Id);
            return Json(new ResultData
            {
                code = ResultCode.ok,
                data = new
                {
                    postCount = postcount,
                    likeCount = likecount
                }
            }, JsonRequestBehavior.AllowGet);
        }

        [Description("获取用户发的帖子")]
        public JsonResult GetUserPost()
        {
            var res = _postService.GetUserPost(Core.AppContext.Current.CurrentUser.User.Id, 1, 10);
            return Json(new ResultData { code = ResultCode.ok, data = res }, JsonRequestBehavior.AllowGet);
        }

        [Description("获取用户收藏的帖子")]
        public JsonResult GetUserLikePost()
        {
            ILikeService likeService = new LikeService();
            var res = likeService.GetLikePostList(Core.AppContext.Current.CurrentUser.User.Id, 1, 10);
            return Json(new ResultData { code = ResultCode.ok, data = res }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult EditProfilePhoto()
        {
            return View();
        }
    }
}