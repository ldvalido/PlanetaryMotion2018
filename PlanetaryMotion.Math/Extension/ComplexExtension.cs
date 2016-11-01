using System.Numerics;

namespace PlanetaryMotion.Math.Extension
{
    public static class ComplexExtension
    {
        public static bool IsAligned(this Complex point, Complex anotherPoint)
        {
            var diffPhase = (point.Phase - anotherPoint.Phase);
            var returnValue = System.Math.Round(diffPhase % (System.Math.PI * 2), 15) == 0;
            return returnValue;
        }

        public static bool BelongsTo(this Complex point, Plane plane)
        {
            return false;
        }
    }
}
