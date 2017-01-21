using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(xss.Web.Startup))]
namespace xss.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
