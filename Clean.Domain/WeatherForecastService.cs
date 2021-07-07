using System.Collections.Generic;

namespace Clean.Domain
{
    public class WeatherForecastService
    {
        private readonly IWeatherForecastApi _weatherForecastApi;

        public WeatherForecastService(IWeatherForecastApi weatherForecastApi)
        {
            _weatherForecastApi = weatherForecastApi;
        }

        public IEnumerable<WeatherForecast> Get(int daysToForecast)
        {
            for (var i = 0; i < daysToForecast; i++)
            {
                yield return _weatherForecastApi.Get(i);
            }
        }
    }
}