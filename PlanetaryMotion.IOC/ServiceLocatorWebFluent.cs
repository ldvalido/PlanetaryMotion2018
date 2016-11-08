using System;
using System.Linq;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;

namespace PlanetaryMotion.IOC
{
    public class ServiceLocatorWebFluent : ServiceLocatorFluent
    {
        #region Overrides of ServiceLocatorFluent

        public override IContainer CreateContainer<T>(T config)
        {
            var loadedAsm = AppDomain.CurrentDomain.GetAssemblies()
                    .Where(asm => asm.FullName.ToLowerInvariant().Contains("planetarymotion"))
                    .ToArray();
            var httpConfig = config as HttpConfiguration;
            Builder = new ContainerBuilder();
            Builder.RegisterAssemblyTypes(loadedAsm)
                .AsImplementedInterfaces()
                .AsSelf()
                .InstancePerDependency().
                PropertiesAutowired();
            Builder.RegisterApiControllers(loadedAsm).PropertiesAutowired();
            Builder.RegisterWebApiFilterProvider(httpConfig);
            return Builder.Build(); 
        }

        #endregion
    }
}
