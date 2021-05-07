using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using System;

namespace PizzaBox.Storing.Repositories
{
  public class OrderRepository : IRepository<Order>
  {
    private readonly PizzaBoxContext _context;
    public OrderRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<Order> Select(Func<Order, bool> filter)
    {
      return new List<Order> { new Order(), new Order() };
    }
    public bool Insert()
    {
      throw new System.NotImplementedException();
    }

    public Order Update()
    {
      throw new System.NotImplementedException();
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

  }
}