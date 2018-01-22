using Core.Entities;
using System.Web;

namespace Core.Application {
    public class WebApplication : ApplicationBase {

        public override BaseUser CurrentUser {
            get {
                if (HttpContext.Current.Session == null) return null;
                return HttpContext.Current.Session[SessionKey.CurrentUser] as BaseUser;
            }
        }
    }
}
