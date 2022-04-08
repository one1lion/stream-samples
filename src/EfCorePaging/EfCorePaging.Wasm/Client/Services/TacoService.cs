using EfCorePaging.Shared.PagerModels;
using EfCorePaging.Shared.ServicesInterfaces;
using EfCorePaging.Shared.ToppingInfoModels;
using SomeTaco.Models;
using System.Net.Http.Json;

namespace EfCorePaging.Client.Services;
public class TacoService : ITacoService
{
    private readonly HttpClient _httpClient;

    public TacoService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ToppingInfo> GetToppings(PagerInfo pagerInfo, CancellationToken ct = default)
    {
        var retResp = new ToppingInfo();
        try
        {
            ct.ThrowIfCancellationRequested();
            var resp = await _httpClient.PostAsJsonAsync("api/Taco/Toppings", pagerInfo, cancellationToken: ct);
            if (!resp.IsSuccessStatusCode)
            {
                throw new Exception($"Bad success is done by the server, so it ain't gonna work: {resp.StatusCode} {resp.ReasonPhrase}");
            }

            retResp = await resp.Content.ReadFromJsonAsync<ToppingInfo>() ?? new();
        }
        catch (OperationCanceledException)
        {
            // User is allowed to cancel the request
            return new();
        }
        catch (Exception)
        {
            throw;
        }

        return retResp;
    }
}
