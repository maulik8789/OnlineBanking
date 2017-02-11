using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VaghelaBank.Startup))]
namespace VaghelaBank
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
