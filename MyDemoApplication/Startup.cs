using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyDemoApplication.Startup))]
namespace MyDemoApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
