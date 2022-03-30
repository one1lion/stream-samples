using EfCorePaging.Shared;
using EfCorePaging.Shared.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace EfCorePaging.Server.Controllers {
  [ApiController]
  [Route("[controller]")]
  public class WeatherForecastController : ControllerBase {
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherForecastService _weatherForecastService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService) {
      _logger = logger;
      _weatherForecastService = weatherForecastService;
    }

    [HttpGet]
    public Task<IEnumerable<WeatherForecast>> Get() {
      return _weatherForecastService.GetAllForecastsAsync();
    }
  }
}