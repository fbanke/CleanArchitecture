using System;
using Clean.Domain;

namespace Clean.Infrastructure
{
    public class WindForecastApi : IWindForecastApi
    {
        private static readonly string[] Summaries = {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public WindForecast Get(int daysAhead)
        {
            var rng = new Random();
            var day = DateTime.Now;
            day = day.AddDays(daysAhead);

            return new WindForecast
            {
                Date = day,
                WindSpeed = rng.Next(1, 5),
                Summary = Summaries[rng.Next(10)]
            };
        }
    }
}