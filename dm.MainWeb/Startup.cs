using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dm.MainWeb.Startup))]
namespace dm.MainWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
