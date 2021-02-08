using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp_RentMovies.Startup))]
namespace WebApp_RentMovies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
