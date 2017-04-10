using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidrent.Startup))]
namespace Vidrent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
