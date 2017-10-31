using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_AccessingWebServices.Startup))]
namespace Lab3_AccessingWebServices
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
