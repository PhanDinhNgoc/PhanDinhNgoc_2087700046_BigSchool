using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhanDinhNgoc_2087700046.Startup))]
namespace PhanDinhNgoc_2087700046
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
