using System.Web.Http;
using PlanetaryMotion.Domain.Contract;
using PlanetaryMotion.Model.Dto;

namespace PlanetaryMotion.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    [RoutePrefix("")]
    public class StatsController : ApiController
    {
        /// <summary>
        /// The weather condition service
        /// </summary>
        private readonly IWeatherHistoryService _weatherHistoryService;
        /// <summary>
        /// Gets the stats.
        /// </summary>
        /// <returns></returns>
        [Route("stats")]
        public StatsDto GetStats()
        {
            return _weatherHistoryService.GetStats();
        }

        public StatsController(IWeatherHistoryService weatherHistoryService)
        {
            _weatherHistoryService = weatherHistoryService;
        }
    }
}
