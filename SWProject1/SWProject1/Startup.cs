using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SWProject1.Startup))]
namespace SWProject1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
