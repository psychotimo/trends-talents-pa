using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(We3.Startup))]
namespace We3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
