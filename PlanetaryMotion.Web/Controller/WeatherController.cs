using System.Collections.Generic;
using System.Web.Http;

namespace PlanetaryMotion.Web.Controller
{
    [RoutePrefix("")]
    public class WeatherController : ApiController
    {
        // GET api/<controller>
        [Route("clima")]
        public IEnumerable<string> GetByDay()
        {
            return new string[] { "value1", "value2" };
        }
    }
}