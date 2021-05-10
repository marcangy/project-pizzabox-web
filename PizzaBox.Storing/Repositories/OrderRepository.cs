using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Storing.Repositories
{
  public class OrderRepository : IRepository<AOrder>
  {
    private readonly PizzaBoxContext _context;
    public OrderRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<AOrder> Select(Func<AOrder, bool> filter)
    {
      return _context.Orders.Where(filter);
    }
    public bool Insert()
    {
      throw new System.NotImplementedException();
    }

    public AOrder Update()
    {
      throw new System.NotImplementedException();
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

  }
}