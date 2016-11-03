using System.Numerics;

namespace PlanetaryMotion.Math
{
    public class Point
    {
        #region C..tor        
        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #region Publica Props        
        /// <summary>
        /// Gets or sets the x.
        /// </summary>
        /// <value>
        /// The x.
        /// </value>
        public int X { get; set; }
        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        /// <value>
        /// The y.
        /// </value>
        public int Y { get; set; }
        #endregion

        #region Public Methods

        public bool IsAligned(Point anotherPoint)
        {
            var anotherComplex =
                Complex.FromPolarCoordinates(
                    System.Math.Sqrt(anotherPoint.X*anotherPoint.X + anotherPoint.Y*anotherPoint.Y),
                    System.Math.Atan2(anotherPoint.X,anotherPoint.Y));

            var thisComplex = Complex.FromPolarCoordinates(System.Math.Sqrt(X * X + Y * Y), System.Math.Atan2(X, Y));

            var diffPhase = System.Math.Abs(anotherComplex.Phase) - System.Math.Abs(thisComplex.Phase);

            return System.Math.Round(diffPhase % (System.Math.PI*2), 15) == 0;

        }
    }
        #endregion
}
