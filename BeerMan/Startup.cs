using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeerMan.Startup))]
namespace BeerMan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
