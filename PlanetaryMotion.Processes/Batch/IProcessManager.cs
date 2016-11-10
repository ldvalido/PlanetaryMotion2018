using Autofac;
using PlanetaryMotion.Processes.Option;

namespace PlanetaryMotion.Processes.Batch
{
    /// <summary>
    /// 
    /// </summary>
    interface IProcessManager
    {
        /// <summary>
        /// Executes the process.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <param name="processOption">The process option.</param>
        void ExecuteProcess(IContainer container, ProcessOption processOption);
    }
}
