using PlanetaryMotion.Domain.Contract;
using PlanetaryMotion.Model;
using PlanetaryMotion.Processes.Option;
using PlanetaryMotion.Storage.Implementation;

namespace PlanetaryMotion.Processes.Batch
{
    public class LoadHistoryForWeatherProcess : ProcessBase
    {
        #region Public Properties
        public WeatherHistoryStorage WeatherHistoryStorage { get; set; }
        public IGalaxyService GalaxyService { get; set; }
        #endregion
        #region Overrides of ProcessBase

        public override void Execute(ProcessOption option)
        {
            for (var i = 0; i < option.Days; i++)
            {
                var weather = GalaxyService.PredictWeather(day: i);
                var weatherHistory = new WeatherHistory { Day = i, Weather = weather };
                WeatherHistoryStorage.Save(weatherHistory);

            }
        }
        #endregion
    }
}
