using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Storing.Repositories
{
  public class CrustRepository : IRepository<Crust>
  {
    private readonly PizzaBoxContext _context;
    public IEnumerable<Crust> Select(Func<Crust, bool> filter)
    {
      return _context.Crusts.Where(filter);
    }
    public CrustRepository(PizzaBoxContext context)
    {
      _context = context;
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