using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(V3.Startup))]
namespace V3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
