using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aspnetsayfaornek.Startup))]
namespace Aspnetsayfaornek
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
