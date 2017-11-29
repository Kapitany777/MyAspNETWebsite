using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyAspNETWebsite.Startup))]
namespace MyAspNETWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
