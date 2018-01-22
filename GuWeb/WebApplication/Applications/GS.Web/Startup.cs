using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GS.Web.Startup))]
namespace GS.Web {
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
        }
    }
}
