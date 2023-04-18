using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CJWebApplication2.Startup))]
namespace CJWebApplication2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app); 
        }
    }
}
