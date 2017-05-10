using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestServices.Web.Startup))]
namespace TestServices.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
