using PlanetaryMotion.Model.Model;

namespace PlanetaryMotion.Model.Poco
{
    /// <summary>
    /// 
    /// </summary>
    public class WeatherPredictionResult
    {
        /// <summary>
        /// Gets or sets the weather condition.
        /// </summary>
        /// <value>
        /// The weather condition.
        /// </value>
        public WeatherCondition WeatherCondition { get; set; }
        /// <summary>
        /// Gets or sets the triangle perimeter.
        /// </summary>
        /// <value>
        /// The triangle perimeter.
        /// </value>
        public double? TrianglePerimeter { get; set; }
    }
}
