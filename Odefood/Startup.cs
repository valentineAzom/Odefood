using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Odefood.Startup))]
namespace Odefood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
