using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrackRoad.WEB.Startup))]
namespace TrackRoad.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
