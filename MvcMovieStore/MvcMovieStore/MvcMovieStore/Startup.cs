using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcMovieStore.Startup))]
namespace MvcMovieStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
