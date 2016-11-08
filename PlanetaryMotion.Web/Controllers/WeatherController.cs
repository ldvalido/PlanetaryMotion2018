using System.Web.Http;
using PlanetaryMotion.Domain.Contract;
using PlanetaryMotion.Model;

namespace PlanetaryMotion.Web.Controllers
{
    [RoutePrefix("")]
    public class WeatherController : ApiController
    {
        readonly IGalaxyService _galaxyService;

        [Route("clima/{day:int}")]
        public WeatherHistory GetWeather(int day)
        {
            var weatherCondition = _galaxyService.PredictWeather(day);
            return new WeatherHistory { Day = day, Weather = weatherCondition };
        }

        public WeatherController(IGalaxyService galaxyService)
        {
            _galaxyService = galaxyService;
        }
    }
}
