using PlanetaryMotion.Domain.Contract;
using PlanetaryMotion.Geometry;

namespace PlanetaryMotion.Domain.Implementation
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="PlanetaryMotion.Domain.Contract.IPlanetMovementService" />
    public class CircularMovementService : IPlanetMovementService
    {
        #region Implementation of IPlanetMovementService        
        /// <summary>
        /// Calculates the specified start.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="angle">The angle.</param>
        /// <param name="days">The days.</param>
        /// <returns></returns>
        public Point Calculate(Point start, double angle, int days)
        {
            return start.MoveAngle(angle*days);
        }

        #endregion
    }
}
