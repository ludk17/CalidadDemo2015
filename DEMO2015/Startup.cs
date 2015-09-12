using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DEMO2015.Startup))]
namespace DEMO2015
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
