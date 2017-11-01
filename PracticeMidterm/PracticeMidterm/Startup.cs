using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticeMidterm.Startup))]
namespace PracticeMidterm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
