using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetMVC.Startup))]
namespace PetMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
