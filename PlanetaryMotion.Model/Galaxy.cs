using System.Collections.Generic;

namespace PlanetaryMotion.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Galaxy
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
        /// Gets or sets the planets.
        /// </summary>
        /// <value>
        /// The planets.
        /// </value>
        public ICollection<Planet> Planets { get; set; }
    }
}
