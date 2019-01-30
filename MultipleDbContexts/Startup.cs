using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultipleDbContexts.Startup))]
namespace MultipleDbContexts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
