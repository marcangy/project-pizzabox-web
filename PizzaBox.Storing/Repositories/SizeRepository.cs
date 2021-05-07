using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using System;

namespace PizzaBox.Storing.Repositories
{
  public class SizeRepository : IRepository<Size>
  {
    private readonly PizzaBoxContext _context;
    public SizeRepository(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<Size> Select(Func<Size, bool> filter)
    {
      return new List<Size> { new Size(), new Size() };
    }
    public bool Insert()
    {
      throw new System.NotImplementedException();
    }

    public Size Update()
    {
      throw new System.NotImplementedException();
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }



  }
}