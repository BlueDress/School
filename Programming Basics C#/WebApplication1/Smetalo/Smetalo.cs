using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Smetalo.Smetalo))]
namespace Smetalo
{
    public partial class Smetalo
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
