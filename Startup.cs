using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Modemspring_next.Startup))]
namespace Modemspring_next
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
