using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
namespace PizzaBox.Storing.Repositories
{
  public class SizeRepository : IRepository<Size>
  {
    public IEnumerable<Size> Select()
    {
      return new List<Size>{new Size(), new Size()};
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