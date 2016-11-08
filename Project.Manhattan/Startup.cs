using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project.Manhattan1.Startup))]
namespace Project.Manhattan1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
