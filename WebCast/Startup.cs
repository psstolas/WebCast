using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebCast.Startup))]
namespace WebCast
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
