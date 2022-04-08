using EfCorePaging.Shared;
using EfCorePaging.Shared.ServicesInterfaces;
using System.Net.Http.Json;

namespace EfCorePaging.Client.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient _httpClient;

        public WeatherForecastService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<IEnumerable<WeatherForecast>> GetAllForecastsAsync()
        {
            return _httpClient.GetFromJsonAsync<IEnumerable<WeatherForecast>>("WeatherForecast");
        }
    }
}
