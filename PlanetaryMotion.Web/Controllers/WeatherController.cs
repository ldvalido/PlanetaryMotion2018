using System.Web.Http;
using PlanetaryMotion.Domain.Contract;
using PlanetaryMotion.Model;

namespace PlanetaryMotion.Web.Controllers
{
    [RoutePrefix("")]
    public class WeatherController : ApiController
    {
        public IGalaxyService GalaxyService { get; set; }
        [Route("clima/{day:int}")]
        public WeatherHistory GetWeather(int day)
        {
            var weatherCondition = GalaxyService.PredictWeather(day);
            return new WeatherHistory { Day = day, Weather = weatherCondition };
        }
    }
}
