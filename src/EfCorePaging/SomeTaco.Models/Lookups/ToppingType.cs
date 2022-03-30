using System.ComponentModel.DataAnnotations;

namespace SomeTaco.Models.Lookups {
  public enum ToppingType {
    None = 1,
    Spinach,
    Cucumber,
    Spoon,
    Hair,
    Mouse,
    Coffee,
    Microphone,
    Microsoft,
    Bacon,
    Egg,
    England,
    [Display(Name = "Cabbage Slaw")]
    CabbageSlaw,
    Pineapple,
    Cheese,
    Salsa,
    [Display(Name = "Sour Cream")]
    SourCream,
    [Display(Name = "Sour Creme")]
    SourCreme,
    [Display(Name = "Creme de Minth")]
    CremeDeMinth,
    [Display(Name = "Diced Tomatoes")]
    DicedTomatoes,
    Lettuce,
    [Display(Name = "Ground Beef")]
    GroundBeef,
    Chicken,
    Chorizo,
    [Display(Name = "Pinto Beans")]
    PintoBeans,
    [Display(Name = "Refried Beans")]
    RefriedBeans,
    [Display(Name = "White Beans")]
    WhiteBeans,
    [Display(Name = "Black Beans")]
    BlackBeans,
    [Display(Name = "Red Kidney Beans")]
    RedKidneyBeans,
    [Display(Name = "Even More Bacon")]
    EvenMoreBacon,
    [Display(Name = "Beef Steak")]
    BeefSteak,
    [Display(Name = "Pulled Pork")]
    PulledPork,
    [Display(Name = "Stake")]
    Stake,
    [Display(Name = "BBQ Pork")]
    BbqPork,
    Fish,
    [Display(Name = "Battered Pork")]
    BatteredFish,
    [Display(Name = "Barnacles")]
    Barnacles
  }
}
