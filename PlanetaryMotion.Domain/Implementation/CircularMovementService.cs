using PlanetaryMotion.Domain.Contract;
using PlanetaryMotion.Geometry;

namespace PlanetaryMotion.Domain.Implementation
{
    public class CircularMovementService : IPlanetMovementService
    {
        #region Implementation of IPlanetMovementService

        public Point Calculate(Point start, double angle, int days)
        {
            return start.MoveAngle(angle*days);
        }

        #endregion
    }
}
