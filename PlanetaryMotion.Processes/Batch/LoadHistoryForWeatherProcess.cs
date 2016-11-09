using PlanetaryMotion.Domain.Contract;
using PlanetaryMotion.Model;
using PlanetaryMotion.Processes.Option;
using PlanetaryMotion.Storage.Implementation;

namespace PlanetaryMotion.Processes.Batch
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="PlanetaryMotion.Processes.Batch.IProcessBase" />
    public class LoadHistoryForWeatherProcess : IProcessBase
    {
        #region Public Properties        
        /// <summary>
        /// Gets or sets the weather history storage.
        /// </summary>
        /// <value>
        /// The weather history storage.
        /// </value>
        public WeatherHistoryStorage WeatherHistoryStorage { get; set; }
        /// <summary>
        /// Gets or sets the galaxy service.
        /// </summary>
        /// <value>
        /// The galaxy service.
        /// </value>
        public IGalaxyService GalaxyService { get; set; }
        #endregion
        #region Overrides of ProcessBase        
        /// <summary>
        /// Executes the specified option.
        /// </summary>
        /// <param name="option">The option.</param>
        public void Execute(ProcessOption option)
        {
            for (var i = 0; i < option.Days; i++)
            {
                var weather = GalaxyService.PredictWeather(day: i);
                var weatherHistory = new WeatherHistory { Day = i, Weather = weather };
                WeatherHistoryStorage.Save(weatherHistory);

            }
        }
        #endregion
    }
}
