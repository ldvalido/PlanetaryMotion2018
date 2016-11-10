using System.Collections.Generic;
using System.Linq;
using Autofac;
using PlanetaryMotion.Domain.Contract;
using PlanetaryMotion.Domain.Test.Poco;
using PlanetaryMotion.Geometry.Extension;
using PlanetaryMotion.IOC;
using PlanetaryMotion.Model.Model;
using Xunit;

namespace PlanetaryMotion.Domain.Test
{
    /// <summary>
    /// 
    /// </summary>
    public class GalaxyServiceTest
    {
        #region Private Properties

        private readonly IEnumerable<Planet> _planets;
        private readonly IContainer _container;
        #endregion

        #region C...tor            
        /// <summary>
        /// Setups this instance.
        /// </summary>
        public GalaxyServiceTest()
        {
            var galaxy = new Galaxy { Id = 1 };
            _planets = new List<Planet>
            {
                new Planet {Angle = 1, Galaxy = galaxy, Id = 1, Name = "Moq Planet #1", Radious = 500},
                new Planet {Angle = 3, Galaxy = galaxy, Id = 2, Name = "Moq Planet #2", Radious = 2000},
                new Planet {Angle = -5, Galaxy = galaxy, Id = 3, Name = "Moq Planet #3", Radious = 1000}
            };
            _container = new ServiceLocatorFluent().CreateContainer<object>(null);

        }
        #endregion

        /// <summary>
        /// Basics the initial test.
        /// </summary>
        [Fact]
        public void BasicInitialTest()
        {    
            var galaxyService = _container.Resolve<IGalaxyService>();
            var res = galaxyService.PredictWeather(_planets,0);
            Assert.Equal(res.WeatherCondition,WeatherCondition.Drought);
            Assert.Null(res.TrianglePerimeter);
        }

        /// <summary>
        /// Basics the test under the sun.
        /// </summary>
        [Fact]
        public void BasicTestUnderTheSun()
        {
            var galaxyService = _container.Resolve<IGalaxyService>();
            var res = galaxyService.PredictWeather(_planets, 181);
            Assert.Equal(res.WeatherCondition, WeatherCondition.Unknown);
            Assert.NotNull(res.TrianglePerimeter);
        }
        /// <summary>
        /// Discover the aligment places on the orbits
        /// </summary>
        [Fact]
        public void DiscoverAligmentPoint()
        {
            var aligmentPoints = new List<AligmentPoint>();
            for (var i = 0; i < 365 * 10; i++)
            {
                double p1Angle = (90 + i * 1) % 360;
                double p2Angle = (90 + i * 3) % 360;
                double p3Angle = (90 - i * 5) % 360;
                if (p3Angle < 0)
                {
                    p3Angle += 360;
                }
                if ((p1Angle - p2Angle).IsMultiple(180) && (p1Angle - p3Angle).IsMultiple(180))
                {
                    aligmentPoints.Add(new AligmentPoint { Day = i, Angle1 = p1Angle, Angle2 = p2Angle, Angle3 = p3Angle });
                }
            }
            Assert.NotEmpty(aligmentPoints);
            var aligmentPointsDoesNotBelongToAxes = aligmentPoints.Where(ap => !ap.Angle1.IsMultiple(90));
            Assert.Empty(aligmentPointsDoesNotBelongToAxes);
        }
    }
}
