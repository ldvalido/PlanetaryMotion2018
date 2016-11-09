using PlanetaryMotion.Processes.Option;

namespace PlanetaryMotion.Processes.Batch
{
    public interface IProcessBase
    {
        void Execute(ProcessOption option);
    }
}
