using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using PlanetaryMotion.Geometry.Extension;

namespace PlanetaryMotion.Geometry
{
    public class Point
    {
        #region Const
        private const double Pi2 = Math.PI *2;
        private const double FromRadian = Math.PI / 180;
        #endregion
        #region C..tor        
        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="complex">The complex.</param>
        private Point(Complex complex)
        {
            X = Math.Round(Math.Cos(complex.Phase) * complex.Magnitude, GeometryConst.CriteriaRound);
            Y = Math.Round(Math.Sin(complex.Phase) * complex.Magnitude, GeometryConst.CriteriaRound);
        }
        #endregion

        #region Publica Props        
        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        /// <value>
        /// The x.
        /// </value>
        public double X { get; set; }
        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        /// <value>
        /// The y.
        /// </value>
        public double Y { get; set; }
        #endregion

        #region Auxiliar Methods        
        /// <summary>
        /// Gets the polar coordinates.
        /// </summary>
        /// <returns></returns>
        private Complex GetPolarCoordinates()
        {
            return Complex.FromPolarCoordinates(Math.Sqrt(X*X+Y*Y), Math.Atan2(Y, X));
        }
        #endregion

        #region Public Methods        
        /// <summary>
        /// Ares the aligned.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns></returns>
        public bool AreAligned(params Point[] point)
        {
            return AreAligned(point.ToList());
        }
        /// <summary>
        /// Ares the aligned.
        /// </summary>
        /// <param name="points">The points.</param>
        /// <returns></returns>
        public bool AreAligned(IEnumerable<Point> points)
        {
            var polar = GetPolarCoordinates();
            var res = points.FirstOrDefault(point =>
            {
                var pointPolar = point.GetPolarCoordinates();
                var angle = polar.Phase - pointPolar.Phase;
                return angle.IsMultiple(Pi2);
            });
            return res == null;
        }
        /// <summary>
        /// Moves the angle.
        /// </summary>
        /// <param name="angle">The angle in grades.</param>
        public Point MoveAngle(double angle)
        {
            var polarCoordinates = GetPolarCoordinates();
            var finalAngle = polarCoordinates.Phase + angle * FromRadian;
            var newPosition = Complex.FromPolarCoordinates(polarCoordinates.Magnitude,finalAngle);
            return new Point(newPosition);

        }
        #endregion
    }

}
