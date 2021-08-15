using System.Collections.Generic;
using Clean.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WindForecastController : ControllerBase
    {
        private readonly WindForecastService _windForecastService;

        public WindForecastController(WindForecastService windForecastService)
        {
            _windForecastService = windForecastService;
        }

        [HttpGet]
        public IEnumerable<WindForecast> Get(int daysToForecast)
        {
            return _windForecastService.Get(daysToForecast);
        }
    }
}