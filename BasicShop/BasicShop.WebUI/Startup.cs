using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasicShop.WebUI.Startup))]
namespace BasicShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
