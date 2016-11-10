namespace PlanetaryMotion.Model.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class WeatherHistory
    {
        /// <summary>
        /// Gets or sets the weather.
        /// </summary>
        /// <value>
        /// The weather.
        /// </value>
        public WeatherCondition Weather {get;set;}
        /// <summary>
        /// Gets or sets the day.
        /// </summary>
        /// <value>
        /// The day.
        /// </value>
        public int Day { get; set; }
        /// <summary>
        /// Gets or sets the triangle perimeter.
        /// </summary>
        /// <value>
        /// The triangle perimeter.
        /// </value>
        public double? TrianglePerimeter { get; set; }
    }
}
