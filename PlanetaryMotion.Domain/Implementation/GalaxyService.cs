using System.Collections.Generic;
using System.Linq;
using PlanetaryMotion.Domain.Contract;
using PlanetaryMotion.Geometry;
using PlanetaryMotion.Model;
using PlanetaryMotion.Storage.Implementation;

namespace PlanetaryMotion.Domain.Implementation
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="PlanetaryMotion.Domain.Contract.IGalaxyService" />
    public class GalaxyService : IGalaxyService
    {
        /// <summary>
        /// Gets or sets the planet movement service.
        /// </summary>
        /// <value>
        /// The planet movement service.
        /// </value>
        public IPlanetMovementService PlanetMovementService { get; set; }
        /// <summary>
        /// Gets or sets the planet storage.
        /// </summary>
        /// <value>
        /// The planet storage.
        /// </value>
        public PlanetStorage PlanetStorage { get; set; }
        #region Implementation of IGalaxyService        
        /// <summary>
        /// Predicts the weather.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <returns></returns>
        public WeatherCondition PredictWeather(int day)
        {
            return PredictWeather(day, 1);
        }
        /// <summary>
        /// Predicts the weather.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <param name="galaxyId">The galaxy identifier.</param>
        /// <returns></returns>
        public WeatherCondition PredictWeather(int day, int galaxyId)
        {
            var lstPoints = new List<Point>();

            var planets = PlanetStorage.GetByCriteria(p => p.Galaxy.Id == galaxyId);

            foreach (var planet in planets)
            {
                var startPoint = new Point(0,planet.Radious);
                var finalPoint = PlanetMovementService.Calculate(startPoint, planet.Angle, day);
                lstPoints.Add(finalPoint);
            }
            
            if (lstPoints.First().AreAligned(lstPoints.Skip(1)))
            {
                var rect = new Rect(lstPoints.First(), lstPoints.Last());
                return rect.Belongs(new Point(0, 0)) ? WeatherCondition.Drought : WeatherCondition.STP;
            }
            else
            {
                var triangle = new Triangle(lstPoints[0],lstPoints[1],lstPoints[2]);
                return triangle.Belongs(new Point(0, 0)) ? WeatherCondition.Rainy : WeatherCondition.Unknown;
            }
        }

        #endregion
    }
}
