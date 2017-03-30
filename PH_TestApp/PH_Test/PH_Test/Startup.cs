using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PH_Test.Startup))]
namespace PH_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
