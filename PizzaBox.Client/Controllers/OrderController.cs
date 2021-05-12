using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Client.Singleton;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
  [Route("[Controller]/[Action]")]
  public class OrderController : Controller
  {

    private static readonly OrderSingleton _orderSingleton = OrderSingleton.Instance;

    private readonly UnitOfWork _unitOfWork;

    public OrderController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    [HttpPost]
    //[ValidateAntiForgeryToken]
    public IActionResult Order(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {

        order = order.Assign(order, _unitOfWork);
        _unitOfWork.Orders.Insert(order.CurrentOrder);
        _unitOfWork.Save();
        ViewBag.Order = order.CurrentOrder;

        return View("checkout");
      }
      order.Load(_unitOfWork);
      return View("Order", order);
    }

    [HttpGet]
    [HttpPost]
    public IActionResult Modify(OrderViewModel order)
    {
      order.Load(_unitOfWork);
      return View("ModifyPizza", order);
    }


  }
}