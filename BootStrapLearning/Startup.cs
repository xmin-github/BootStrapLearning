using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootStrapLearning.Startup))]
namespace BootStrapLearning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
