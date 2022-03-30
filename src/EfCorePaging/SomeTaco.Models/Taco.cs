using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeTaco.Models; 
public class Taco {
  public int Id { get; set; }
  public string Name { get; set; } = default!;
  public DateTime? Created { get; set; }

  public virtual ICollection<Topping> Toppings { get; set; } =  new List<Topping>();
}
