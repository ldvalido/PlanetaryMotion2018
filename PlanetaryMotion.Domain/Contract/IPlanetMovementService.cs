using PlanetaryMotion.Geometry;

namespace PlanetaryMotion.Domain.Contract
{
    public interface IPlanetMovementService
    {
        Point Calculate(Point start, double angle, int days);
    }
}
