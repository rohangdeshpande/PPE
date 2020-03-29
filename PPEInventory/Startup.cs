using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PPEInventory.Startup))]
namespace PPEInventory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
