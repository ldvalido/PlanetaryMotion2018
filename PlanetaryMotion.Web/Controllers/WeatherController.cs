using System.Web.Http;
using PlanetaryMotion.Domain.Contract;
using PlanetaryMotion.Model;
using PlanetaryMotion.Model.Model;
using PlanetaryMotion.Storage.Implementation;

namespace PlanetaryMotion.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    [RoutePrefix("")]
    public class WeatherController : ApiController
    {
        readonly IGalaxyService _galaxyService;

                /// <summary>
        /// Gets or sets the planet storage.
        /// </summary>
        /// <value>
        /// The planet storage.
        /// </value>
        public PlanetStorage PlanetStorage { get; set; }
        /// <summary>
        /// Gets the weather.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <returns></returns>
        [Route("clima/{day:int}")]
        public WeatherHistory GetWeather(int day)
        {
            var planets = PlanetStorage.GetByCriteria(p => p.Galaxy.Id == _galaxyService.DefaultGalaxyId());
            var weatherCondition = _galaxyService.PredictWeather(planets, day);
            return new WeatherHistory { Day = day, Weather = weatherCondition };
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherController"/> class.
        /// </summary>
        /// <param name="galaxyService">The galaxy service.</param>
        public WeatherController(IGalaxyService galaxyService)
        {
            _galaxyService = galaxyService;
        }
    }
}
