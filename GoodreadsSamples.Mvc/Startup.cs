using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoodreadsSamples.Mvc.Startup))]
namespace GoodreadsSamples.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
