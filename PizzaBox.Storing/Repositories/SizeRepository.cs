using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace PizzaBox.Storing.Repositories
{
  public class SizeRepository : IRepository<Size>
  {
    private const string _path = @"data/sizes.xml";
    private static FileRepository _filerepository = new FileRepository();
    public List<Size> ListSize { get; set; }
    private readonly PizzaBoxContext _context;
    public SizeRepository(PizzaBoxContext context)
    {
      ListSize = _filerepository.ReadFromFile<List<Size>>(_path);
      _context = context;
    }
    public IEnumerable<Size> Select(Func<Size, bool> filter)
    {
      return _context.Sizes.Where(filter);
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