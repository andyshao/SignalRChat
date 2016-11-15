using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRChat.Web.Startup))]
namespace SignalRChat.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
