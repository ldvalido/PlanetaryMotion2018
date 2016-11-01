using System;
using System.Numerics;
using PlanetaryMotion.Math.Extension;

namespace PlanetaryMotion.Math
{
    /// <summary>
    /// 
    /// </summary>
    public class Plane
    {
        #region C...tor
        public Plane(Complex  p1,Complex p2,Complex p3)
        {
            if (!p1.IsAligned(p2) && !p1.IsAligned(p3))
            {
                P1 = p1;
                P2 = p2;
                P3 = p3;
            }
            else
            {
                throw new ArgumentException("The points are aligned and the plane cannot be built");
            }
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// 
        /// </summary>
        public Complex P1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Complex P2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Complex P3 { get; set; }
        #endregion
    }
}
