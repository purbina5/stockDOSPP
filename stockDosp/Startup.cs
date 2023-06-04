using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(stockDosp.Startup))]
namespace stockDosp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
