using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactFormEmailer.Startup))]
namespace ContactFormEmailer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
