using System;
using System.Collections.Generic;
using PizzaBox.Storing.Repositories;
using PizzaBox.Storing;
using PizzaBox.Domain.Models;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Abstracts;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PizzaBox.Client.Models
{
  public class OrderViewModel : IValidatableObject
  {


    public List<ACustomer> Customers { get; set; }
    public List<AStore> Stores { get; set; }
    public List<Crust> Crusts { get; set; }
    public List<Size> Sizes { get; set; }
    public List<Topping> Toppings { get; set; }
    public List<APizza> Pizzas { get; set; }

    public List<SelectListItem> ListOfPizzas { get; set; }

    public long OrderNumber { get; set; }

    [Required(ErrorMessage = "selected crust")]
    [DataType(DataType.Text)]
    public string SelectedCrust { get; set; }

    [Required(ErrorMessage = "selected Pizza")]
    public string SelectedPizza { get; set; }

    [Required(ErrorMessage = "selected size")]
    public string SelectedSize { get; set; }

    [Required(ErrorMessage = "selected topping")]
    public List<string> SelectedToppings { get; set; }

    [Required(ErrorMessage = "selected customer")]
    public string SelectedCustomer { get; set; }

    [Required(ErrorMessage = "selected store")]
    public string SelectedStore { get; set; }

    public RegOrder CurrentOrder { get; set; } = new RegOrder { Pizzas = new List<APizza> { } };

    public void Load(UnitOfWork unitOfWork)
    {
      Crusts = unitOfWork.Crusts.ListCrust;
      Sizes = unitOfWork.Sizes.ListSize;
      Toppings = unitOfWork.Toppings.ListTopping;
      Pizzas = unitOfWork.Pizzas.ListPizzas;
      Customers = unitOfWork.Customers.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
      Stores = unitOfWork.Stores.Select(s => !string.IsNullOrWhiteSpace(s.Name)).ToList();
      ListOfPizzas = Pizzas.Select(p => new SelectListItem { Text = p.Name, Value = p.Name }).ToList();


    }

    public OrderViewModel Assign(OrderViewModel order, UnitOfWork unitOfWork)
    {
      order.CurrentOrder.Customer = unitOfWork.Customers.Select(c => c.Name == order.SelectedCustomer).First();
      order.CurrentOrder.Store = unitOfWork.Stores.Select(s => s.Name == order.SelectedStore).First();
      var chosenPizza = unitOfWork.Pizzas.Select(p => p.Name == order.SelectedPizza).First();
      if (chosenPizza.Name == "Custom Pizza")
      {
        chosenPizza.Crust = unitOfWork.Crusts.Select(c => c.Name == order.SelectedCrust).First();
        chosenPizza.Size = unitOfWork.Sizes.Select(s => s.Name == order.SelectedSize).First();
        var toppings = new List<Topping>();
        foreach (var item in order.SelectedToppings)
        {
          toppings.Add(unitOfWork.Toppings.Select(t => t.Name == item).First());
        }

      }
      if (chosenPizza != null)
      {
        order.CurrentOrder.Pizzas.Add(chosenPizza);
      }
      return order;
    }





    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      //create instance of collection
      if (SelectedToppings.Count < 2 || SelectedToppings.Count > 5)
      {
        yield return new ValidationResult("are you crazy!", new string[] { "SelectedToppings" });
      }

      //return instance of collection
    }



  }
}