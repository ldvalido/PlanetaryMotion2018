using CommandLine;
using CommandLine.Text;

namespace PlanetaryMotion.Processes.Option
{
    public class ProcessOption
    {
        [Option('d',"days",Required=false,HelpText = "Indicates the quantity of days for the calculation",DefaultValue = 10*365)]
        public int Days { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
              (current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
