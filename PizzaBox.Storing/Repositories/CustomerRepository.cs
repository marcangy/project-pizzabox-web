using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Storing.Repositories
{
  public class CustomerRepository : IRepository<ACustomer>
  {
    private readonly PizzaBoxContext _context;
    public CustomerRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<ACustomer> Select(Func<ACustomer, bool> filter)
    {
      return _context.Customers.Where(filter);
    }
    public bool Insert(ACustomer item)
    {
      throw new System.NotImplementedException();
    }

    public ACustomer Update()
    {
      throw new System.NotImplementedException();
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

  }
}