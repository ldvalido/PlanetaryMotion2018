using PlanetaryMotion.Processes.Option;

namespace PlanetaryMotion.Processes.Batch
{
    /// <summary>
    /// 
    /// </summary>
    public interface IProcessBase
    {
        /// <summary>
        /// Executes the specified option.
        /// </summary>
        /// <param name="idExecution">The option.</param>
        void Execute(int idExecution);
    }
}
