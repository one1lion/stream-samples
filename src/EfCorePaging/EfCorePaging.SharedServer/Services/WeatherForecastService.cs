using EfCorePaging.Shared;
using EfCorePaging.Shared.ServicesInterfaces;
using Microsoft.Extensions.Logging;

namespace EfCorePaging.SharedServer.Services {
  public class WeatherForecastService : IWeatherForecastService {
    private static readonly string[] Summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

    private readonly ILogger<WeatherForecastService> _logger;
    public WeatherForecastService(ILogger<WeatherForecastService> logger) {
      _logger = logger;
    }

    public Task<IEnumerable<WeatherForecast>> GetAllForecastsAsync() {
      return Task.FromResult(Enumerable.Range(1, 8).Select(index => new WeatherForecast {
        Date = DateTime.Now.AddDays(index),
        TemperatureC = Random.Shared.Next(-20, 55),
        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
      }));
    }
  }
}
