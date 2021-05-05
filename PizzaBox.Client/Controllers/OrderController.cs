using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Controllers
{
  [Route("[Controller]")]
  public class OrderController : Controller
  {
    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public string Order(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {
        return order.SelectedCrust;
      }
      return "Please select an Order";
    }


  }
}