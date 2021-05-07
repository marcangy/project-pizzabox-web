using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{

  public class Topping : AComponent
  {
    public ICollection<APizza> pizzas;
    public Topping()
    {
      Price = 1.5;
    }
  }

}

