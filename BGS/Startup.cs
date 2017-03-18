using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BGS.Startup))]
namespace BGS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
