using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using System;

namespace PizzaBox.Storing.Repositories
{
  public class ToppingRepository : IRepository<Topping>
  {

    //public delegate bool ToppingDelegate(Topping topping);
    private readonly PizzaBoxContext _context;
    public ToppingRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<Topping> Select(Func<Topping, bool> filter)
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