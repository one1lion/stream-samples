using EfCorePaging.Shared.PagerModels;
using EfCorePaging.Shared.ToppingInfoModels;

namespace EfCorePaging.Shared.ServicesInterfaces;
public interface ITacoService
{
    Task<ToppingInfo> GetToppings(PagerInfo pagerInfo, CancellationToken ct = default);
}
