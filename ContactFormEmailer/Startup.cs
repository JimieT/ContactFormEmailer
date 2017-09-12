using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactFormEmailer.Web.Startup))]
namespace ContactFormEmailer.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
