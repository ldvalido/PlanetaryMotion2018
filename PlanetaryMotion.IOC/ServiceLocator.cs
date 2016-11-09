using System;
using System.Linq;
using System.Reflection;
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

        #region Virtual Methods        
        /// <summary>
        /// Creates the container.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="config">The configuration.</param>
        /// <returns></returns>
        public virtual IContainer CreateContainer<T>(T config)
        {
            LoadAssemblies();

            var loadedAsm = AppDomain.CurrentDomain.GetAssemblies().
                Where(asm => asm.FullName.ToLowerInvariant().Contains("planetarymotion")).
                ToArray();

            Builder = new ContainerBuilder();
            Builder.RegisterAssemblyTypes(loadedAsm)
                .AsImplementedInterfaces()
                .AsSelf()
                .InstancePerDependency().
                PropertiesAutowired();
            OnCreateContainer(Builder,loadedAsm, config);
            return Builder.Build();
        }
        /// <summary>
        /// Called when [create container].
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="builder">The builder.</param>
        /// <param name="loadedAssemblies">The loaded assemblies.</param>
        /// <param name="config">The configuration.</param>
        protected virtual void OnCreateContainer<T>(ContainerBuilder builder, Assembly[] loadedAssemblies, T config)
        {
           
        }
        #endregion

        #region Private Methods
        void LoadAssemblies()
        {
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                this.LoadReferencedAssembly(assembly);
            }
        }

        void LoadReferencedAssembly(Assembly assembly)
        {
            foreach (var name in assembly.GetReferencedAssemblies())
            {
                if (AppDomain.CurrentDomain.GetAssemblies().All(a => a.FullName != name.FullName))
                {
                    LoadReferencedAssembly(Assembly.Load(name));
                }
            }
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
