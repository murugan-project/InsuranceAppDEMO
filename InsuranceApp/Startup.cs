using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InsuranceApp.Startup))]
namespace InsuranceApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
