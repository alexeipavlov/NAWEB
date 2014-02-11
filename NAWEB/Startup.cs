using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NAVEB.Startup))]
namespace NAVEB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
