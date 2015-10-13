using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(portfolio.UI.Startup))]
namespace portfolio.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
