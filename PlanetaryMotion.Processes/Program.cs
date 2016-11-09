using Autofac;
using PlanetaryMotion.IOC;
using PlanetaryMotion.Processes.Batch;
using PlanetaryMotion.Processes.Option;

namespace PlanetaryMotion.Processes
{
    class Program
    {
        static void Main(string[] args)
        {

            var options = new ProcessOption();
            if (CommandLine.Parser.Default.ParseArguments(args, options))
            {
                var container = new ServiceLocatorFluent().CreateContainer<object>(null);

                var application = container.Resolve<IProcessBase>();

                application.Execute(options);
            }
        }
    }
}
