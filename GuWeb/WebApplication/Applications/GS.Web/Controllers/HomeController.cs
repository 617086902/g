using DotNet.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TF.BitterMelon.Entities;

namespace GS.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.d = DateTime.Now.ToString("yyyy-MM-dd");
            return View();
        }

        public ActionResult Test()
        {
            ViewBag.BaseDir = AppDomain.CurrentDomain.BaseDirectory;
            string wr = "";
            try
            {
                string cookieFile = ConstStr.WeiboCookiePath;
                string cookieStr = FileOperate.ReadFile(cookieFile);
                ViewBag.cookiestr = cookieStr;
                string filePath = ConstStr.WeiboContentPath("abc");
                FileOperate.WriteFile(filePath, "test");
            }
            catch (Exception ex)
            {
                wr = ex.StackTrace;
            }
            ViewBag.wr = wr;
            return View();
        }
    }
}