using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SowAndReap.WebMVC.Startup))]
namespace SowAndReap.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
