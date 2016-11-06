using System.Web.Http;
using PlanetaryMotion.Domain.Contract;
using PlanetaryMotion.Model;

namespace PlanetaryMotion.Web.Controller
{
    [RoutePrefix("")]
    public class WeatherController : ApiController
    {
        public IGalaxyService GalaxyService { get; set; } 

        // GET api/<controller>
        [Route("clima/{day:int}")]
        public WeatherHistory GetByDay(int day)
        {
            var weatherCondition = GalaxyService.PredictWeather(day);
            return new WeatherHistory {Day = day, Weather = weatherCondition};
        }
    }
}