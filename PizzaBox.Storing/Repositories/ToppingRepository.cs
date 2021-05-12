using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Storing.Repositories
{
  public class ToppingRepository : IRepository<Topping>
  {

    private const string _path = @"data/toppings.xml";
    private static FileRepository _filerepository = new FileRepository();
    public List<Topping> ListTopping { get; set; }
    private readonly PizzaBoxContext _context;
    public ToppingRepository(PizzaBoxContext context)
    {
      //ListTopping = _filerepository.ReadFromFile<List<Topping>>(_path);
      _context = context;
    }
    public IEnumerable<Topping> Select(Func<Topping, bool> filter)
    {
      return _context.Toppings.Where(filter);
    }
    public bool Insert(Topping item)
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