using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyTextBooksMain.Startup))]
namespace MyTextBooksMain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
