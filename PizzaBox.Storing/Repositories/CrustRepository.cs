using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Storing.Repositories
{
  public class CrustRepository : IRepository<Crust>
  {
    private const string _path = @"data/crusts.xml";
    private static FileRepository _filerepository = new FileRepository();
    public List<Crust> ListCrust { get; set; }
    private readonly PizzaBoxContext _context;
    public IEnumerable<Crust> Select(Func<Crust, bool> filter)
    {
      return _context.Crusts.Where(filter);
    }
    public CrustRepository(PizzaBoxContext context)
    {
      //ListCrust = _filerepository.ReadFromFile<List<Crust>>(_path);
      _context = context;
    }

    public bool Insert(Crust item)
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