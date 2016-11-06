using System;
using PlanetaryMotion.Domain.Implementation;
using PlanetaryMotion.Geometry;
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
            Assert.Equal(finalPoint.X,-1d,GeometryConst.CriteriaRound);
            Assert.Equal(finalPoint.Y,0d,GeometryConst.CriteriaRound);
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
            Assert.Equal(finalPoint.X, Math.Sqrt(2) / -2, GeometryConst.CriteriaRound);
            Assert.Equal(finalPoint.Y, Math.Sqrt(2) / 2, GeometryConst.CriteriaRound);
        }
    }
}
