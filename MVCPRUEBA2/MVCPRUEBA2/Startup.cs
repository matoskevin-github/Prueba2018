using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPRUEBA2.Startup))]
namespace MVCPRUEBA2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
