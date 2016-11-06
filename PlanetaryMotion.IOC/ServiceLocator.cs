using Autofac;

namespace PlanetaryMotion.IOC
{
    public class ServiceLocator
    {
        #region Public Properties
        static IContainer Container { get; set; }
        #endregion
        #region C..tor

        public ServiceLocator()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes();
            Container = builder.Build();

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
