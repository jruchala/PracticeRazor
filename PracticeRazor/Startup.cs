using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticeRazor.Startup))]
namespace PracticeRazor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
