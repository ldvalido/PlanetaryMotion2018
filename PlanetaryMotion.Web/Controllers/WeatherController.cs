using System.Web.Http;
using PlanetaryMotion.Domain.Contract;
using PlanetaryMotion.Model;

namespace PlanetaryMotion.Web.Controllers
{
    [RoutePrefix("")]
    public class WeatherController : ApiController
    {
        readonly IGalaxyService _galaxyService;

        /// <summary>
        /// Gets the weather.
        /// </summary>
        /// <param name="day">The day.</param>
        /// <returns></returns>
        [Route("clima/{day:int}")]
        public WeatherHistory GetWeather(int day)
        {
            var weatherCondition = _galaxyService.PredictWeather(day);
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
