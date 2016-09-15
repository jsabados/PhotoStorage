using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhotoStorage.Startup))]
namespace PhotoStorage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
