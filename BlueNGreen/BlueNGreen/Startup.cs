using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlueNGreen.Startup))]
namespace BlueNGreen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
