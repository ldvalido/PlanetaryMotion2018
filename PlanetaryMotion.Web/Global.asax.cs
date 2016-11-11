using System.Web.Http;
using Autofac.Integration.WebApi;
using PlanetaryMotion.IOC;

namespace PlanetaryMotion.Web
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Web.HttpApplication" />
    public class WebApiApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// Applications the start.
        /// </summary>
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            var config = GlobalConfiguration.Configuration;
            var builder = new ServiceLocatorWebFluent().CreateContainer(config).Build();
            // Set the dependency resolver to be Autofac.
            config.DependencyResolver = new AutofacWebApiDependencyResolver(builder.GetRawContainer());
        }
    }
}
