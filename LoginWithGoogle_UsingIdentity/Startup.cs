using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoginWithGoogle_UsingIdentity.Startup))]
namespace LoginWithGoogle_UsingIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
