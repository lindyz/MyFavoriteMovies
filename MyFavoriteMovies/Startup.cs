using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFavoriteMovies.Startup))]
namespace MyFavoriteMovies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
