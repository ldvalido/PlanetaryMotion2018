using System.Collections;
using System.Collections.Generic;

namespace PlanetaryMotion.Model
{
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
        /// Gets or sets the planets.
        /// </summary>
        /// <value>
        /// The planets.
        /// </value>
        public IEnumerable<Planet> Planets { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Galaxy"/> class.
        /// </summary>
        public Galaxy()
        {
            Planets = new List<Planet>();
        }
    }
}
