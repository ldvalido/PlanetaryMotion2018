using PlanetaryMotion.Model.Dto;

namespace PlanetaryMotion.Domain.Contract
{
    /// <summary>
    /// 
    /// </summary>
    public interface IWeatherHistoryService
    {
        /// <summary>
        /// Gets the stats.
        /// </summary>
        /// <returns></returns>
        StatsDto GetStats();
    }
}
