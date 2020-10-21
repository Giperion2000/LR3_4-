using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LR3_4.Startup))]
namespace LR3_4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
