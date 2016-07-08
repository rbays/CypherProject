using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FormsKeyPairsPage.Startup))]
namespace FormsKeyPairsPage
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
