using System;

namespace PlanetaryMotion.Geometry
{
    /// <summary>
    /// 
    /// </summary>
    public class Rect
    {
        #region Private Properties
        private readonly double _a;
        private readonly double _b;
        private readonly Point _vertex1;
        private readonly Point _vertex2;
        #endregion
        #region C...tor        
        /// <summary>
        /// Initializes a new instance of the <see cref="Rect"/> class.
        /// </summary>
        /// <param name="vertex1">The vertex1.</param>
        /// <param name="vertex2">The vertex2.</param>
        public Rect(Point vertex1, Point vertex2)
        {
            _vertex1 = vertex1;
            _vertex2 = vertex2;
            //(y-y1) / (y2-y1) = (x-x1) / (x2-x1)
            var factor = (vertex2.Y - vertex1.Y)/(vertex2.X - vertex1.X);
            _b = factor*vertex1.X - vertex1.Y;
            _a = factor;
        }
        #endregion
        #region Public Method        
        /// <summary>
        /// Belongses the specified point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns></returns>
        public bool Belongs(Point point)
        {
            return Math.Round(point.Y,GeometryConst.CriteriaRound) == Math.Round(point.X*_a + _b,GeometryConst.CriteriaRound);
        }
        /// <summary>
        /// Gets the length.
        /// </summary>
        /// <returns></returns>
        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(_vertex1.X-_vertex2.X,2) + Math.Pow(_vertex1.Y - _vertex2.Y,2));
        }
        #endregion
    }
}
