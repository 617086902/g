using BusinessService;
using BusinessService.Entities;
using CommonService.Sms;
using Core;
using Core.Entities;
using Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Web.Mvc;

namespace GS.Web.Controllers
{
    public class CommonController : Controller
    {
        [Description("生成图形验证码")]
        public ActionResult GetCodeImg()
        {
            int width = 90, height = 25, fontsize = 20;
            string code = string.Empty;
            byte[] bytes = VerificationCode.CreateValidateGraphic(out code, 4, width, height, fontsize);
            SessionHelper.SetSession(SessionKey.ValidCode, code);
            return File(bytes, @"image/jpeg");
        }

        [Description("验证图形验证码")]
        public JsonResult CheckValidCode(string code)
        {
            if (!SessionHelper.Exist(SessionKey.ValidCode))
                return Json(new ResultData { code = ResultCode.fail, msg = "获取验证码失败", }, JsonRequestBehavior.AllowGet);
            if (!SessionHelper.GetSession(SessionKey.ValidCode).Equals(code, StringComparison.InvariantCultureIgnoreCase))
                return Json(new ResultData { code = ResultCode.fail, msg = "验证码不正确", }, JsonRequestBehavior.AllowGet);
            return Json(new ResultData { code = ResultCode.ok }, JsonRequestBehavior.AllowGet);
        }

        [Description("发送短信验证码")]
        public JsonResult SendMessage(string userAccount)
        {
            //发送次数限制
            if (SessionHelper.Exist(SessionKey.SendMessageTimes))
            {
                int maxSendTimes = 3;
                int sendTimes = SessionHelper.GetSession<int>(SessionKey.SendMessageTimes);
                if (sendTimes > maxSendTimes)
                    return Json(new ResultData { code = ResultCode.fail, msg = "发送次数限制，请半小时后重试", }, JsonRequestBehavior.AllowGet);
            }
            //频繁发送限制
            if (SessionHelper.Exist(SessionKey.lastSendTime))
            {
                int timeInterval = 1;//发送间隔
                DateTime lastSendTime = SessionHelper.GetSession<DateTime>(SessionKey.lastSendTime);
                if (lastSendTime.AddMinutes(timeInterval) > DateTime.Now)
                    return Json(new ResultData { code = ResultCode.fail, msg = "验证码发送频繁", }, JsonRequestBehavior.AllowGet);
            }
            string code = RandomOperate.RandomNumCode(6);
            string template = string.Format("您正在进行用户注册，验证码{0}，有效时间30分钟，请勿向任何人提供您收到的验证码。", code);
            bool res = false;
            //发送验证码
            if (userAccount.Contains('@')) res = EmailHelper.SendMail(userAccount, "一股一十注册验证码", template, null);
            else res = SmsHelper.Send(userAccount, template);
            //发送成功
            if (res)
            {
                SessionHelper.SetSession(SessionKey.RegistValidCode, userAccount + "-" + code);
                SessionHelper.SetSession(SessionKey.lastSendTime, DateTime.Now);
            }
            return Json(new ResultData { code = res ? ResultCode.ok : ResultCode.fail }, JsonRequestBehavior.AllowGet);
        }


        [Description("验证验证码")]
        public JsonResult CheckMessageCode(string userAccount, string code)
        {
            if (!SessionHelper.Exist(SessionKey.RegistValidCode))
                return Json(new ResultData { code = ResultCode.fail, msg = "请重新获取验证码", }, JsonRequestBehavior.AllowGet);
            if (SessionHelper.GetSession(SessionKey.RegistValidCode) != userAccount + "-" + code)
                return Json(new ResultData { code = ResultCode.fail, msg = "验证码不正确", }, JsonRequestBehavior.AllowGet);
            //验证成功，删除session
            SessionHelper.DeleteSession(SessionKey.RegistValidCode);
            SessionHelper.SetSession(SessionKey.ValidUserAccount, userAccount);
            return Json(new ResultData { code = ResultCode.ok }, JsonRequestBehavior.AllowGet);
        }

        [Description("喜欢或取消喜欢")]
        [HttpPost]
        public JsonResult LikeOrUnLike(int targetId, TargetType targetType, bool isLike)
        {
            ILikeService likeService = new LikeService();
            var res = likeService.LikeOrUnLike(targetId, targetType, isLike);
            return Json(new ResultData { code = ResultCode.ok }, JsonRequestBehavior.DenyGet);
        }

        [Description("是否喜欢")]
        public JsonResult IsLike(int targetId, TargetType targetType)
        {
            if (AppContext.Current.CurrentUser == null)
                return Json(new ResultData { code = ResultCode.fail }, JsonRequestBehavior.AllowGet);
            ILikeService likeService = new LikeService();
            var res = likeService.IsLike(targetId, targetType);
            return Json(new ResultData { code = ResultCode.ok, data = res }, JsonRequestBehavior.AllowGet);
        }

        [Description("上传头像")]
        public JsonResult UploadImg(string imgdata)
        {
            var base64 = imgdata.Replace("data:image/jpeg;base64,", "");
            byte[] bytes = Convert.FromBase64String(base64);
            MemoryStream memStream = new MemoryStream();
            foreach (byte b in bytes)
            {
                memStream.WriteByte(b);
            }
            Image img = Image.FromStream(memStream);
            //BinaryFormatter binFormatter = new BinaryFormatter();
            //Image img = (Image)binFormatter.Deserialize(memStream);
            string imgPath = "/content/img/user/" + Guid.NewGuid().ToString().Replace("-", "") + ".jpeg";
            img.Save(Request.MapPath(imgPath), System.Drawing.Imaging.ImageFormat.Jpeg);
            IUserService userService = new UserService();
            Core.AppContext.Current.CurrentUser.UserInformation.ProfilePhoto = imgPath;
            userService.EditProfile(Core.AppContext.Current.CurrentUser.UserInformation);
            return Json(imgPath, "text/plain");
        }
    }
}