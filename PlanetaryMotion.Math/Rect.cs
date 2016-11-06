using System;

namespace PlanetaryMotion.Geometry
{
    /// <summary>
    /// 
    /// </summary>
    public class Rect
    {
        #region Private Properties

        private readonly Point _vertex1;
        private readonly Point _vertex2;
        private double a, b;
        #endregion
        #region C...tor
        public Rect(Point vertex1, Point vertex2)
        {
            _vertex1 = vertex1;
            _vertex2 = vertex2;
            //(y-y1) / (y2-y1) = (x-x1) / (x2-x1)
            var factor = (vertex2.Y - vertex1.Y)/(vertex2.X - vertex1.X);
            b = factor*vertex1.X - vertex1.Y;
            a = factor;
        }
        #endregion
        #region Public Method

        public bool Belongs(Point point)
        {
            return Math.Round(point.Y,GeometryConst.CriteriaRound) == Math.Round(point.X*a + b,GeometryConst.CriteriaRound);
        }
        #endregion
    }
}
