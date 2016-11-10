using System.Linq;
using PlanetaryMotion.Domain.Contract;
using PlanetaryMotion.Model.Dto;
using PlanetaryMotion.Model.Model;
using PlanetaryMotion.Storage.Implementation;

namespace PlanetaryMotion.Domain.Implementation
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="IWeatherHistoryService" />
    public class WeatherHistoryService : IWeatherHistoryService
    {
        public WeatherHistoryStorage WeatherHistoryStorage { get; set; }
        #region Implementation of IWeatherHistoryService        
        /// <summary>
        /// Gets the stats.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public StatsDto GetStats()
        {
            var grouping = WeatherHistoryStorage.
                GetAll().
                GroupBy(wh => wh.Weather);
            var returnValue = new StatsDto
            {
                DroughtPeriods = grouping.FirstOrDefault(p => p.Key == WeatherCondition.Drought)?.Count(),
                StpPeriods = grouping.FirstOrDefault(p => p.Key == WeatherCondition.STP)?.Count(),
                RainyPeriods= grouping.FirstOrDefault(p => p.Key == WeatherCondition.Rainy)?.Count(),
                UnknownPeriods = grouping.FirstOrDefault(p => p.Key == WeatherCondition.Unknown)?.Count(),
            };
            return returnValue;
        }

        #endregion
    }
}
