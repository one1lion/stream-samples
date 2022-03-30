using SomeTaco.Models.Lookups;

namespace SomeTaco.Models;

public partial class Topping {
  public ToppingType Id { get; set; }
  public string Name { get; set; } = default!;

  public ICollection<Taco> Tacos { get; set; }
}
