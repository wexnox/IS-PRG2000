using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(obligatorisk3.Startup))]
namespace obligatorisk3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
