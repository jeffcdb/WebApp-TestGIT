using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp_TestGIT.Startup))]
namespace WebApp_TestGIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
