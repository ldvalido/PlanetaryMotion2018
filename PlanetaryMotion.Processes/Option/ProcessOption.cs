﻿using CommandLine;
using CommandLine.Text;

namespace PlanetaryMotion.Processes.Option
{
    /// <summary>
    /// 
    /// </summary>
    public class ProcessOption
    {
        /// <summary>
        /// Gets or sets the days.
        /// </summary>
        /// <value>
        /// The days.
        /// </value>
        [Option('d',"days",Required=false,HelpText = "Indicates the quantity of days for the calculation",DefaultValue = 10*365)]
        public int Days { get; set; }
        [Option('p',"progress",Required = false,HelpText = "Indicates the quantity of execution to show progress",DefaultValue = 100)]
        public int DeliveryResume { get; set; }
        /// <summary>
        /// Gets the usage.
        /// </summary>
        /// <returns></returns>
        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
              current => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
