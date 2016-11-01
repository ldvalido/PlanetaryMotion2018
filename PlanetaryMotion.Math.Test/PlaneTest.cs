using System.Numerics;
using PlanetaryMotion.Math.Extension;
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
            var p1 = Complex.FromPolarCoordinates(1, 0);
            var p2 = Complex.FromPolarCoordinates(1, System.Math.PI * 2);
            var res = p1.IsAligned(p2);
            Assert.True(res);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void TestNonAlignment()
        {
            var p1 = Complex.FromPolarCoordinates(1, 0);
            var p2 = Complex.FromPolarCoordinates(1, System.Math.PI);
            var res = p1.IsAligned(p2);
            Assert.False(res);
        }

        [Fact]
        public void TestInvalidPlane()
        {
            var p1 = Complex.FromPolarCoordinates(1, 0);
            var p2 = Complex.FromPolarCoordinates(1, System.Math.PI * 2);
            var p3 = Complex.FromPolarCoordinates(1, System.Math.PI * 4);
            Assert.True(p1.IsAligned(p2));
            Assert.True(p1.IsAligned(p3));
            var plane = new Plane(p1,p2,p3);
        }
    }
}
