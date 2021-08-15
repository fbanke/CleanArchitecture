using System.Collections.Generic;

namespace Clean.Domain
{
    public class WindForecastService
    {
        private readonly IWindForecastApi _windForecastApi;

        public WindForecastService(IWindForecastApi windForecastApi)
        {
            _windForecastApi = windForecastApi;
        }

        public IEnumerable<WindForecast> Get(int daysToForecast)
        {
            for (var i = 0; i < daysToForecast; i++)
            {
                yield return _windForecastApi.Get(i);
            }
        }
    }
}