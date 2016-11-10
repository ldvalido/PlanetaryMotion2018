using PlanetaryMotion.Model.Poco;

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
        StatsPoco GetStats();
    }
}
