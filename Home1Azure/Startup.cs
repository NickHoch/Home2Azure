using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Home1Azure.Startup))]
namespace Home1Azure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
