using System;

namespace Clean.Domain
{
    public class WindForecast
    {
        public DateTime Date { get; set; }

        public int WindSpeed { get; set; }

        public string Summary { get; set; }
    }
}