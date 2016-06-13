using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sandbox1.web.Startup))]
namespace Sandbox1.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
