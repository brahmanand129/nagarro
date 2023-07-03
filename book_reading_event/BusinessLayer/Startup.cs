using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BusinessLayer.StartupOwin))]

namespace BusinessLayer
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
