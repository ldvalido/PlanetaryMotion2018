using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;

namespace PlanetaryMotion.IOC
{
    public class ServiceLocatorWebFluent : ServiceLocatorFluent
    {
        #region Overrides of ServiceLocatorFluent

        /// <summary>
        /// Called when [create container].
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder">The builder.</param>
        /// <param name="loadedAssemblies">The loaded assemblies.</param>
        /// <param name="config">The configuration.</param>
        protected override void OnCreateContainer<T>(ContainerBuilder builder, Assembly[] loadedAssemblies, T config)
        {
            var httpConfiguration = config as HttpConfiguration;
            Builder.RegisterApiControllers(loadedAssemblies).PropertiesAutowired();
            Builder.RegisterWebApiFilterProvider(httpConfiguration);
        }

        #endregion
    }
}
