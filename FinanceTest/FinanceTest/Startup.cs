using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinanceTest.Startup))]
namespace FinanceTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
