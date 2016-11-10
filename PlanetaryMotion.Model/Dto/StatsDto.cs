namespace PlanetaryMotion.Model.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class StatsDto
    {
        /// <summary>
        /// Gets or sets the rainy periods.
        /// </summary>
        /// <value>
        /// The rainy periods.
        /// </value>
        public int? RainyPeriods { get; set; }
        /// <summary>
        /// Gets or sets the drought periods.
        /// </summary>
        /// <value>
        /// The drought periods.
        /// </value>
        public int? DroughtPeriods { get; set; }
        /// <summary>
        /// Gets or sets the rainy periods.
        /// </summary>
        /// <value>
        /// The rainy periods.
        /// </value>
        public int? StpPeriods { get; set; }
        /// <summary>
        /// Gets or sets the unknown periods.
        /// </summary>
        /// <value>
        /// The unknown periods.
        /// </value>
        public int? UnknownPeriods { get; set; }
        /// <summary>
        /// Gets or sets the maximum triangle perimter.
        /// </summary>
        /// <value>
        /// The maximum triangle perimter.
        /// </value>
        public double? MaxTrianglePerimter { get; set; }
    }
}
