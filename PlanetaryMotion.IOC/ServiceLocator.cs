using System;
using System.Linq;
using Autofac;

namespace PlanetaryMotion.IOC
{
    public class ServiceLocatorFluent
    {
        #region Public Properties
        static protected IContainer Container { get; set; }
        #endregion
        #region Private Properties

        protected ContainerBuilder Builder;
        #endregion
        #region C..tor

        public ServiceLocatorFluent()
        {

        }
        #endregion
        #region Virtual Methods

        public virtual IContainer CreateContainer<T>(T config)
        {
            var loadedAsm =
                AppDomain.CurrentDomain.GetAssemblies();
            Builder = new ContainerBuilder();
            Builder.RegisterAssemblyTypes(loadedAsm);
            return Builder.Build();
        }
        #endregion
        #region Public Methods

        public T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
        #endregion
    }
}
