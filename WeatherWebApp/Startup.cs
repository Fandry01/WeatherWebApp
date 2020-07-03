using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeatherWebApp.Startup))]
namespace WeatherWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
