using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IntroduccionMVC.Startup))]
namespace IntroduccionMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
