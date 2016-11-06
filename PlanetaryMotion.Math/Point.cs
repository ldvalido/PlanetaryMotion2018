using System;
using System.Numerics;

namespace PlanetaryMotion.Geometry
{
    public class Point
    {
        #region Const
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

        private Complex GetPolarCoordinates()
        {
            return Complex.FromPolarCoordinates(Math.Sqrt(X*X+Y*Y), Math.Atan2(Y, X));
        }
        #endregion

        #region Public Methods
        public bool AreAligned(Point point2,Point point3)
        {
            return (X == point2.X && X == point3.X) ||
                   (Y == point2.Y && Y == point3.Y);
        }
        /// <summary>
        /// Moves the angle.
        /// </summary>
        /// <param name="angle">The angle in grades.</param>
        public Point MoveAngle(double angle)
        {
            var polarCoordinates = GetPolarCoordinates();
            var finalAngle = polarCoordinates.Phase + angle * FromRadian;
            var newPosition = Complex.FromPolarCoordinates(polarCoordinates.Real,finalAngle);
            return new Point(newPosition);

        }
        #endregion
    }

}
