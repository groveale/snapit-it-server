using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(split_it_server.Startup))]

namespace split_it_server
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}