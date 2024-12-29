using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Work_Code.Startup))]
namespace Work_Code
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
