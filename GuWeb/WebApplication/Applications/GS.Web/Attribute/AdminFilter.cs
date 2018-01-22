using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GS.Web.Attribute
{
    public class AdminFilter : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (Core.AppContext.Current.CurrentUser == null || Core.AppContext.Current.CurrentUser.User.Mobile != ConfigHelper.Get("AdminMobile"))
            {
                RedirectResult r = new RedirectResult("/Assist/Error?errType=10001");
                filterContext.RequestContext.HttpContext.Response.Redirect("/Assist/Error?errType=10001", true);
                filterContext.RequestContext.HttpContext.Response.End();
                filterContext.Result = new EmptyResult();
            }
        }
    }
}