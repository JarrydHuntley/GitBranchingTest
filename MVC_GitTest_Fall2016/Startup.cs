using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_GitTest_Fall2016.Startup))]
namespace MVC_GitTest_Fall2016
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
