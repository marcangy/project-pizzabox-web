using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Storing.Repositories
{

  public class PizzaRepository : IRepository<APizza>
  {
    private const string _path = @"data/pizzas.xml";
    private static FileRepository _filerepository = new FileRepository();
    public List<APizza> ListPizzas { get; set; }
    private readonly PizzaBoxContext _context;
    public PizzaRepository(PizzaBoxContext context)
    {
      ListPizzas = _filerepository.ReadFromFile<List<APizza>>(_path);
      _context = context;
    }
    public IEnumerable<APizza> Select(Func<APizza, bool> filter)
    {
      return _context.Pizzas.Where(filter);
    }
    public bool Insert()
    {
      throw new System.NotImplementedException();
    }

    public APizza Update()
    {
      throw new System.NotImplementedException();
    }
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

  }
}