using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
namespace PizzaBox.Storing.Repositories
{
  public class ToppingRepository : IRepository<Topping>
  {
    public IEnumerable<Topping> Select()
    {
      return new List<Topping> { new Topping(), new Topping() };
    }
    public bool Insert()
    {
      throw new System.NotImplementedException();
    }

    public Topping Update()
    {
      throw new System.NotImplementedException();
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}