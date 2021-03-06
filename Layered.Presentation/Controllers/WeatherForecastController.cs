using System.Collections.Generic;
using Layered.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Layered.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly WeatherForecastService _weatherForecastService;

        public WeatherForecastController(WeatherForecastService weatherForecastService, ILogger<WeatherForecastController> logger)
        {
            _weatherForecastService = weatherForecastService;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get(int daysToForecast)
        {
            return _weatherForecastService.Get(daysToForecast);
        }
    }
}