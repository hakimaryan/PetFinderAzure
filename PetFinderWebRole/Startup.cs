using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetFinderWebRole.Startup))]
namespace PetFinderWebRole
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
