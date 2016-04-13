using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimbreStation.Startup))]
namespace TimbreStation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
