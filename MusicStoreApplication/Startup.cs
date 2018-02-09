using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicStoreApplication.Startup))]
namespace MusicStoreApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
