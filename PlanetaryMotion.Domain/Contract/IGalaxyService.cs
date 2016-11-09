using PlanetaryMotion.Model;

namespace PlanetaryMotion.Domain.Contract
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGalaxyService
    {
        /// <summary>
        /// Predicts the weather.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <returns></returns>
        WeatherCondition PredictWeather(int day);
        /// <summary>
        /// Predicts the weather.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="galaxyId">The galaxy identifier.</param>
        /// <returns></returns>
        WeatherCondition PredictWeather(int day, int galaxyId);
    }
}
