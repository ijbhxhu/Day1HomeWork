using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day1HomeWork.Startup))]
namespace Day1HomeWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
