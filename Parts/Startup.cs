using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Parts.Startup))]
namespace Parts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
