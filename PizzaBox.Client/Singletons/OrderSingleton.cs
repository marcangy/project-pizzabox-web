using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using System.Collections.Generic;
using PizzaBox.Storing.Repositories;
using PizzaBox.Storing;
using System.Linq;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Singleton
{

  public class OrderSingleton
  {
    private static OrderSingleton _instance;
    public OrderViewModel order { get; set; }



    public static OrderSingleton Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new OrderSingleton();
        }

        return _instance;

      }

    }
    public OrderViewModel Orders
    {

      get
      {

        return order;

      }

    }
    public void SaveOrder(AOrder order, PizzaBoxContext _context)
    {

      _context.Orders.Add(order);
      _context.SaveChanges();

    }

    private OrderSingleton()
    {



    }


  }
}