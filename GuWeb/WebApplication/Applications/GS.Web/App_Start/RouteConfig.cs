using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GS.Web {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "MiniBlog",
                url: "weibo/{d}",
                defaults: new { controller = "MiniBlog", action = "Index", d = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "guba",
                url: "guba/{code}",
                defaults: new { controller = "Guba", action = "Index", code = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "postdetials",
                url: "p/{postId}",
                defaults: new { controller = "Guba", action = "PostDetials", postId = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "postlist",
                url: "post/{action}",
                defaults: new { controller = "Guba", action = "Index" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
