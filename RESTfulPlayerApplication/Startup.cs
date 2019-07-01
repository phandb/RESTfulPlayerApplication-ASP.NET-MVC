using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RESTfulPlayerApplication.Startup))]
namespace RESTfulPlayerApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
