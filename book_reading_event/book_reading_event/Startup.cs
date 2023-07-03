using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(book_reading_event.Startup))]
namespace book_reading_event
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
