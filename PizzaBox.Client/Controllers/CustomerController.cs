using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Controllers
{
  [Route("[Controller]")]
  public class CustomerController : Controller
  {

    [HttpGet]
    [HttpPost]
    public string Customer(CustomerViewModel customer)
    {
      if (ModelState.IsValid)
      {
        return customer.SelectedName;
      }
      return "Please enter Name";
    }


  }
}