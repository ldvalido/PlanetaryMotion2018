using System;
using PlanetaryMotion.Domain.Implementation;
using PlanetaryMotion.Geometry;
using PlanetaryMotion.Geometry.Extension;
using Xunit;

namespace PlanetaryMotion.Domain.Test
{
    public class CircularMovementTest
    {
        /// <summary>
        /// Tests the basic movement.
        /// </summary>
        [Fact]
        public void TestBasicMovement()
        {
            var startPoint = new Point(x:0, y:1);
            var circular = new CircularMovementService();
            var finalPoint = circular.Calculate(startPoint,angle: 1,days: 90);
            Assert.True(finalPoint.X.IsSimilar(-1d));
            Assert.True(finalPoint.Y.IsSimilar(0d));
        }
        /// <summary>
        /// Tests the basic movement.
        /// </summary>
        [Fact]
        public void TestHalfOctantMovement()
        {
            var startPoint = new Point(x: 0, y: 1);
            var circular = new CircularMovementService();
            var finalPoint = circular.Calculate(startPoint, angle: 1, days: 45);
            Assert.True(finalPoint.X.IsSimilar(Math.Sqrt(2) / -2));
            Assert.True(finalPoint.Y.IsSimilar(Math.Sqrt(2) / 2));
        }
    }
}
