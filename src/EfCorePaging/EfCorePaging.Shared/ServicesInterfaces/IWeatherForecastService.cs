namespace EfCorePaging.Shared.ServicesInterfaces
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecast>> GetAllForecastsAsync();
    }
}
