using EfCorePaging.Shared.ServicesInterfaces;
using EfCorePaging.SharedServer.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SomeTaco.Database;

namespace EfCorePaging.SharedServer.Extensions {
  public static class ServiceExtensions {
    public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration) {
      services.AddDbContext<SomeTacoContext>(options =>
        options.UseSqlServer(
          configuration.GetConnectionString("DbContext"),
          b => b.MigrationsAssembly("EfCorePaging.Server")));
    }

    public static void ConfigureServerServices(this IServiceCollection services) {
      services.AddScoped<ITacoService, TacoService>();
      services.AddScoped<IWeatherForecastService, WeatherForecastService>();
    }
  }
}
