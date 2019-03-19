using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment2Group3.Startup))]
namespace Assignment2Group3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
