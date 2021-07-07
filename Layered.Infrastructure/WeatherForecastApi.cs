using System;

namespace Layered.Infrastructure
{
    public class WeatherForecastApi
    {
        public WeatherForecastDao Get(int daysAhead)
        {
            var rng = new Random();
            var day = DateTime.Now;
            day = day.AddDays(daysAhead);

            return new WeatherForecastDao
            {
                Date = day,
                TemperatureC = rng.Next(-20, 55),
                Summary = rng.Next(10)
            };
        }
    }
}