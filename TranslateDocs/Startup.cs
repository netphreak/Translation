using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranslateDocs.Startup))]
namespace TranslateDocs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
