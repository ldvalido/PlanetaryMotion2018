using System;
using Xunit;

namespace PlanetaryMotion.Math.Test
{
    public class PlaneTest
    {
        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void TestAlignment()
        {
            var p1 = new Point(10, 1);
            var p2 = new Point(-10, 1);
            var res = p1.IsAligned(p2);
            Assert.True(res);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void TestNonAlignment()
        {
            var p1 = new Point(0, 1);
            var p2 = new Point(1, 0);
            var res = p1.IsAligned(p2);
            Assert.False(res);
        }

        [Fact]
        public void TestInvalidPlane()
        {
            var p1 = new Point(1, 1);
            var p2 = new Point(-1, 1);
            var p3 = new Point(-1, 2);
            Assert.True(p1.IsAligned(p2));
            Assert.Throws<ArgumentException>(() => new Plane(p1, p2, p3));
        }
    }
}
