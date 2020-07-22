using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(REALTEST.Startup))]
namespace REALTEST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
