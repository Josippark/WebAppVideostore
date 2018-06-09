using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppVideostore.Startup))]
namespace WebAppVideostore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
