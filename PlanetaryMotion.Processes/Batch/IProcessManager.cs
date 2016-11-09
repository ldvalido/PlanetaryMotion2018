using PlanetaryMotion.Processes.Option;

namespace PlanetaryMotion.Processes.Batch
{
    interface IProcessManager
    {
        void ExecuteProcess(ProcessOption processOption);
    }
}
