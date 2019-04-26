using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(diplom.Startup))]
namespace diplom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
