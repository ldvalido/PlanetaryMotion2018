using PlanetaryMotion.Geometry;

namespace PlanetaryMotion.Domain.Contract
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPlanetMovementService
    {
        /// <summary>
        /// Calculates the specified start.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="angle">The angle.</param>
        /// <param name="days">The days.</param>
        /// <returns></returns>
        Point Calculate(Point start, double angle, int days);
    }
}
