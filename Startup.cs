using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoKarting.Startup))]
namespace GoKarting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
