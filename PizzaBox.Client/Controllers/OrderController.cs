using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
  [Route("[Controller]")]
  public class OrderController : Controller
  {

    private readonly UnitOfWork _unitOfWork;

    public OrderController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Order(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {
        return View("checkout");
      }
      order.Load(_unitOfWork);
      return View("order", order);
    }


  }
}