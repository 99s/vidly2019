using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly20119.Startup))]
namespace Vidly20119
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
