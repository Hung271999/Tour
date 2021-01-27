using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GrowProjects.Startup))]
namespace GrowProjects
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
