using System.Collections.Generic;
using PlanetaryMotion.Model;

namespace PlanetaryMotion.Domain.Contract
{
    public interface IGalaxyService
    {
        WeatherCondition PredictWeather(int day);
        WeatherCondition PredictWeather(int day, int galaxyId);
    }
}
