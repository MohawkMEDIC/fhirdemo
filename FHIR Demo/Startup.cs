using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FHIR_Demo.Startup))]
namespace FHIR_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
