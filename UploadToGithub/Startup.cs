using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UploadToGithub.Startup))]
namespace UploadToGithub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
