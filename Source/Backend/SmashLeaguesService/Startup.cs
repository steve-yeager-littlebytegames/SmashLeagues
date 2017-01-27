using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SmashLeaguesService.Startup))]

namespace SmashLeaguesService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}