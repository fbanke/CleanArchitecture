namespace Clean.Domain
{
    public interface IWindForecastApi
    {
        WindForecast Get(int daysAhead);
    }
}