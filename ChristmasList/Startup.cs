using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChristmasList.Startup))]
namespace ChristmasList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
