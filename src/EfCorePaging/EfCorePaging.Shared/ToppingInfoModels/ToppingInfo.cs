using EfCorePaging.Shared.PagerModels;
using SomeTaco.Models;

namespace EfCorePaging.Shared.ToppingInfoModels;
public class ToppingInfo
{
    public List<Topping>? CurrentToppingsList { get; set; }
    public PagerInfo PagerInfo { get; set; } = new();
}
