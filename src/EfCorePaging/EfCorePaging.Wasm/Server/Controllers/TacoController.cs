using EfCorePaging.Shared.PagerModels;
using EfCorePaging.Shared.ServicesInterfaces;
using EfCorePaging.Shared.ToppingInfoModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SomeTaco.Models;

namespace EfCorePaging.Server.Controllers; 
[Route("api/[controller]")]
[ApiController]
public class TacoController : ControllerBase {
  private readonly ITacoService _tacoService;

  public TacoController(ITacoService tacoService) {
    _tacoService = tacoService;
  }

  [HttpPost("Toppings")]
  public Task<ToppingInfo> GetToppings(PagerInfo pagerInfo, CancellationToken ct = default) {
    return _tacoService.GetToppings(pagerInfo, ct);
  }
}
