using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigHubMosh.Startup))]
namespace GigHubMosh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            
        }
    }
}
