using System.Collections.Generic;
using PlanetaryMotion.Model;
using PlanetaryMotion.Model.Model;
using PlanetaryMotion.Model.Poco;

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
        /// <param name="planets">The planets.</param>
        /// <param name="day">The day.</param>
        /// <returns></returns>
        WeatherPredictionResult PredictWeather(IEnumerable<Planet> planets, int day);

        /// <summary>
        /// Gets or sets the default galaxy identifier.
        /// </summary>
        /// <value>
        /// The default galaxy identifier.
        /// </value>
        int DefaultGalaxyId();
    }
}
