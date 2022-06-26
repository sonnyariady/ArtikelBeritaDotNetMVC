using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Artikel.Startup))]
namespace Artikel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
