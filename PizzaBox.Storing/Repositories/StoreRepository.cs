using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Storing.Repositories
{
  public class StoreRepository : IRepository<AStore>
  {
    private readonly PizzaBoxContext _context;
    public StoreRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<AStore> Select(Func<AStore, bool> filter)
    {
      return _context.Stores.Where(filter);
    }
    public bool Insert(AStore item)
    {
      throw new System.NotImplementedException();
    }

    public AStore Update()
    {
      throw new System.NotImplementedException();
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

  }
}