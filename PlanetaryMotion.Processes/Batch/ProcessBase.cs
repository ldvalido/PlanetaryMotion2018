using PlanetaryMotion.Processes.Option;

namespace PlanetaryMotion.Processes.Batch
{
    public abstract class ProcessBase
    {
        public abstract void Execute(ProcessOption option);
    }
}
