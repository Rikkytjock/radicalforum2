using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RadicalGamingForum.Startup))]
namespace RadicalGamingForum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
