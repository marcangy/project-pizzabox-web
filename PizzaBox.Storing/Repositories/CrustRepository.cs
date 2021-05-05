using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;
using System.Collections.Generic;

namespace PizzaBox.Storing.Repositories
{
  public class CrustRepository : IRepository<Crust>
  {
    public IEnumerable<Crust> Select()
    {
      return new List<Crust> { new Crust(), new Crust() };
    }
    public bool Insert()
    {
      throw new System.NotImplementedException();
    }

    public Crust Update()
    {
      throw new System.NotImplementedException();
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}