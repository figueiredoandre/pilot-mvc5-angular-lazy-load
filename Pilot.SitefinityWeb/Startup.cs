using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pilot.SitefinityWeb.Startup))]
namespace Pilot.SitefinityWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
