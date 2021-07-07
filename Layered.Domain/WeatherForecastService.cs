using System.Collections.Generic;
using Layered.Infrastructure;

namespace Layered.Domain
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly WeatherForecastApi _weatherForecastApi;

        public WeatherForecastService(WeatherForecastApi weatherForecastApi)
        {
            _weatherForecastApi = weatherForecastApi;
        }

        public IEnumerable<WeatherForecast> Get(int daysToForecast)
        {
            for (var i = 0; i < daysToForecast; i++)
            {
                var weatherForecast = _weatherForecastApi.Get(i);
                
                yield return new WeatherForecast
                {
                    Date = weatherForecast.Date,
                    TemperatureC = weatherForecast.TemperatureC,
                    Summary = Summaries[weatherForecast.Summary]
                };
            }
        }
    }
}