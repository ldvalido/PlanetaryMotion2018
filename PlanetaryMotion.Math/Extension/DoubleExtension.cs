using System;

namespace PlanetaryMotion.Geometry.Extension
{
    public static class DoubleExtension
    {
        public static bool IsMultiple(this double aDouble, double anotherDouble)
        {
            return Math.Round(aDouble%anotherDouble,GeometryConst.CriteriaRound) == 0;
        }
    }
}
