using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectMars.Startup))]
namespace ProjectMars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
