using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment_satyasir.Startup))]
namespace Assignment_satyasir
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
