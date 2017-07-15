using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(leo.Startup))]
namespace leo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
