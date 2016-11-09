using System;
using System.Diagnostics;
using PlanetaryMotion.Processes.Batch;

namespace PlanetaryMotion.Processes.Option
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="PlanetaryMotion.Processes.Batch.IProcessManager" />
    public class ProcessManager : IProcessManager
    {
        #region Process Base        
        /// <summary>
        /// Gets or sets the process.
        /// </summary>
        /// <value>
        /// The process.
        /// </value>
        public IProcessBase Process { get; set; }
        #endregion
        #region Implementation of IProcessManager        
        /// <summary>
        /// Executes the process.
        /// </summary>
        /// <param name="processOption">The process option.</param>
        public void ExecuteProcess(ProcessOption processOption)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var previousColor = Console.ForegroundColor;
            try
            {   
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The process is preparing to execute");

                for (var i = 0; i < processOption.Days; i++)
                {
                    if (i % processOption.DeliveryResume == 0)
                    {
                        Console.WriteLine($"Executing process #{i} of {processOption.Days}");
                    }
                    Process.Execute(processOption.Days);
                }
                
                
                Console.WriteLine("The execution was succesfully");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"An error was ocurre: {ex.Message}" );
            }
            Console.ForegroundColor = previousColor;
            stopWatch.Stop();
            Console.WriteLine($"Time Elapsed: {stopWatch.ElapsedMilliseconds / 1000} seconds");
        }

        #endregion
    }
}
