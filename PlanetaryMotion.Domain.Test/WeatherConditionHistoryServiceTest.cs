using System.Collections.Generic;
using Moq;
using PlanetaryMotion.Domain.Implementation;
using PlanetaryMotion.IOC;
using PlanetaryMotion.Model.Model;
using PlanetaryMotion.Storage.Implementation;
using Xunit;

namespace PlanetaryMotion.Domain.Test
{
    /// <summary>
    /// 
    /// </summary>
    public class WeatherConditionHistoryServiceTest
    {
        /// <summary>
        /// Basics the grouping test.
        /// </summary>
        [Fact]
        public void BasicGroupingTest()
        {
            var builder = new ServiceLocatorFluent().CreateContainer<object>(null);

            var mockWeatherhistoryStorage = new Mock<WeatherHistoryStorage>();
            mockWeatherhistoryStorage.Setup(storage => storage.GetAll()).Returns(
                new List<WeatherHistory>
                {
                    new WeatherHistory {Day = 0, TrianglePerimeter = 10, Weather = WeatherCondition.Drought},
                    new WeatherHistory {Day = 1, TrianglePerimeter = 20, Weather = WeatherCondition.STP},
                    new WeatherHistory {Day = 2, TrianglePerimeter = 30, Weather = WeatherCondition.Drought},
                    new WeatherHistory {Day = 3, TrianglePerimeter = 40, Weather = WeatherCondition.Unknown},
                    new WeatherHistory {Day = 4, TrianglePerimeter = 50, Weather = WeatherCondition.Rainy},
                });
            var container = builder.Register(mockWeatherhistoryStorage.Object).Build();
            var service = container.Resolve<WeatherHistoryService>();
            var stats = service.GetStats();
            Assert.Equal(stats.MaxTrianglePerimter, 50);
            Assert.Equal(stats.DroughtPeriods, 2);
        }
    }
}
