using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPRUEBA3.Startup))]
namespace MVCPRUEBA3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
