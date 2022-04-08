using Blazored.LocalStorage;
using Microsoft.Extensions.DependencyInjection;

namespace EfCorePaging.Shared.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureBlazoredLocalStorage(this IServiceCollection services)
    {
        services.AddBlazoredLocalStorage();
    }
}
