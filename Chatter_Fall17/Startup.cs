using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chatter_Fall17.Startup))]
namespace Chatter_Fall17
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
