using EfCorePaging.Client;
using EfCorePaging.Client.Services;
using EfCorePaging.Shared.ServicesInterfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<ITacoService, TacoService>();
builder.Services.AddSingleton<IWeatherForecastService, WeatherForecastService>();

await builder.Build().RunAsync();
