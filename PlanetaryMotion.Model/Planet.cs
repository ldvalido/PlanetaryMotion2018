namespace PlanetaryMotion.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Planet
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the angle.
        /// </summary>
        /// <value>
        /// The angle.
        /// </value>
        public double Angle { get; set; }
        /// <summary>
        /// Gets or sets the radious.
        /// </summary>
        /// <value>
        /// The radious.
        /// </value>
        public double Radious { get; set; }
        /// <summary>
        /// Gets or sets the galaxy.
        /// </summary>
        /// <value>
        /// The galaxy.
        /// </value>
        public Galaxy Galaxy { get; set; }
    }
}
