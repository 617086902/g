using CommonService.Weibo;
using Core;
using Core.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TF.BitterMelon.AnalogLogin.SinaWeibo;
using TF.BitterMelon.Entities;
using TF.BitterMelon.Tool;

namespace GS.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            AppContext.Start(new WebApplication());
            #region 定时器
            System.Timers.Timer timer = new System.Timers.Timer(5 * 60 * 1000);
            timer.Enabled = true;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(GrabWeibo);
            timer.Start();
            #endregion
        }
        private void GrabWeibo(object sender, System.Timers.ElapsedEventArgs args)
        {
            WeiboHelper.Get();
        }
    }
}
