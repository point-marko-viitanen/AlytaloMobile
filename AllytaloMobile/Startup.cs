using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AllytaloMobile.Startup))]
namespace AllytaloMobile
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
