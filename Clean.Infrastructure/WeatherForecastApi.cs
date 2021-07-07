using System;
using Clean.Domain;

namespace Clean.Infrastructure
{
    public class WeatherForecastApi : IWeatherForecastApi
    {
        private static readonly string[] Summaries = {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public WeatherForecast Get(int daysAhead)
        {
            var rng = new Random();
            var day = DateTime.Now;
            day = day.AddDays(daysAhead);

            return new WeatherForecast
            {
                Date = day,
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(10)]
            };
        }
    }
}