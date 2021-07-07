namespace Clean.Domain
{
    public interface IWeatherForecastApi
    {
        WeatherForecast Get(int daysAhead);
    }
}