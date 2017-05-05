using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArrayWays.Startup))]
namespace ArrayWays
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
