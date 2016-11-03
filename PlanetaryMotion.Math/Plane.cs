using System;
using System.Numerics;

namespace PlanetaryMotion.Math
{
    /// <summary>
    /// 
    /// </summary>
    public class Plane
    {
        #region C...tor
        public Plane(Point  p1,Point p2,Point p3)
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
        public Point P1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Point P2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Point P3 { get; set; }
        #endregion
        
        #region Public Methods

        public bool Belongs(Point point)
        {
            return false;
        }
        #endregion
    }
}
