using System.Web.Http;
using Autofac.Integration.WebApi;
using PlanetaryMotion.IOC;

namespace PlanetaryMotion.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            var config = GlobalConfiguration.Configuration;
            var builder = new ServiceLocatorWebFluent().CreateContainer(config);
            // Set the dependency resolver to be Autofac.
            config.DependencyResolver = new AutofacWebApiDependencyResolver(builder);
        }
    }
}
