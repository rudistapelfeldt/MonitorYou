using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MonitorYouService.Startup))]

namespace MonitorYouService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}