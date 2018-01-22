using CommonService.Page;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TF.BitterMelon.AnalogLogin.SinaWeibo;
using TF.BitterMelon.Entities;
using TF.BitterMelon.Tool;
using System.Collections.Generic;
using CommonService.Weibo;
using Core.Utilities;
using GS.Web.Attribute;

namespace GS.Web.Controllers
{
    public class MiniBlogController : Controller
    {
        public ActionResult Index(string d, int pn = 1)
        {
            if (d == "") d = DateTime.Now.ToString("yyyy-MM-dd");
            int ps = 30;
            List<WeiboDetails> dlist = new List<WeiboDetails>();
            string[] kws = new[] { "大盘", "股票", "a股" };
            List<string> clist = new List<string>();
            foreach (var k in kws)
            {
                var l = FileOperate.Read(ConstStr.WeiboContentPath(k, d));
                if (l == null || !l.Any()) continue;
                clist.AddRange(l);
            }
            foreach (var c in clist)
            {
                if (string.IsNullOrEmpty(c)) continue;
                var weibo = JsonConvert.DeserializeObject<WeiboDetails>(c);
                if (weibo != null)
                    dlist.Add(weibo);
            }
            ViewBag.Pager = "";
            ViewBag.Hot = dlist.Count;
            ViewBag.d = d;
            ViewBag.p = !dlist.Any() && d != DateTime.Now.ToString("yyyy-MM-dd") ? "" : Convert.ToDateTime(d).AddDays(-1).ToString("yyyy-MM-dd");
            if (!dlist.Any()) return View(dlist);
            //分页，后台生成是为了让搜索引擎抓取
            bool ismobile = Core.Utilities.MobileHelper.IsMoblie(Request);
            int pageCount = (int)Math.Ceiling(dlist.Count * 1.00 / ps);
            string host = "/weibo/" + d;
            ViewBag.Pager = PageHelper.GetPageHtml(pn, pageCount, host, ismobile);
            dlist = dlist.OrderByDescending(c => c.Pubdate).ToList().Skip((pn - 1) * ps).Take(ps).ToList();
            return View(dlist);
        }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <returns></returns>
        [AdminFilter]
        public ActionResult Add()
        {
            DateTime date = string.IsNullOrEmpty(Request.QueryString["date"]) ? default(DateTime) : Convert.ToDateTime(Request.QueryString["date"]);
            WeiboHelper.Get(date);
            return View();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        [AdminFilter]
        public ActionResult Login(int r = 0)
        {
            string u = ConfigHelper.Get("WeiboUserCode");
            string p = ConfigHelper.Get("WeiboPassCode");
            WeiboLogin wl = new WeiboLogin(u, p, Server.MapPath("/") + "\\d\\weiboCookie.txt");
            if (r != 0 || !wl.IsLogin)
            {
                ViewBag.LoginRes = wl.L(true);
            }
            ViewBag.cookie = wl.LoginCookie;
            return View();
        }

        public ActionResult ShowPath()
        {
            ViewBag.path = Server.MapPath("/");
            return View();
        }
    }
}