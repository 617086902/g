using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace GS.Web.Controllers
{
    public class AssistController : Controller
    {
        private Dictionary<int, string> ErrTypeDic;
        public AssistController()
        {
            ErrTypeDic = new Dictionary<int, string>
            {
                {404,"抱歉，您访问的页面不存在！" },
                {500,"服务器内部错误，请稍后重试！" },
                {301,"页面跳转！" },
                {10001,"您的权限不足，无法进行此操作" },
            };
        }
        public ActionResult Error(int errType = 404)
        {
            if (ErrTypeDic.ContainsKey(errType))
            {
                ViewBag.Tip = ErrTypeDic[errType];
            }
            switch (errType)
            {
                case 404: Response.StatusCode = (int)HttpStatusCode.NotFound; break;
                case 500: Response.StatusCode = (int)HttpStatusCode.InternalServerError; break;
                case 301: Response.StatusCode = (int)HttpStatusCode.Moved; break;
            }
            return View();
        }

        [Description("更新日志")]
        public ActionResult ChangeLog()
        {
            return View();
        }
    }
}