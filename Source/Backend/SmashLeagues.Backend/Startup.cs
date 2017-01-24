using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SmashLeagues.Backend.Startup))]

namespace SmashLeagues.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}