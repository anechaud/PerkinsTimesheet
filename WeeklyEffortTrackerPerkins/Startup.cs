using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeeklyEffortTrackerPerkins.Startup))]
namespace WeeklyEffortTrackerPerkins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
