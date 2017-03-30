using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PH_TestApp.Startup))]
namespace PH_TestApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
