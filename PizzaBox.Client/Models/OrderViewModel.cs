using System;
using System.Collections.Generic;
using PizzaBox.Storing.Repositories;
using PizzaBox.Storing;
using PizzaBox.Domain.Models;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Client.Models
{
  public class OrderViewModel : IValidatableObject
  {
    public List<Crust> Crusts { get; set; } = new List<Crust>();
    public List<Size> Sizes { get; set; } = new List<Size>();
    public List<Topping> Toppings { get; set; } = new List<Topping>();


    [Required(ErrorMessage = "selected crust")]
    [DataType(DataType.Text)]
    public string SelectedCrust { get; set; }

    [Required(ErrorMessage = "selected size")]
    [DataType(DataType.Text)]
    public string SelectedSize { get; set; }

    [Required(ErrorMessage = "selected topping")]
    public List<string> SelectedToppings { get; set; }


    public OrderViewModel(UnitOfWork unitOfWork)
    {
      Crusts = unitOfWork.Crusts.Select().ToList();
      Sizes = unitOfWork.Sizes.Select().ToList();
      Toppings = unitOfWork.Toppings.Select().ToList();

    }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      //create instance of collection
      if (SelectedCrust == SelectedSize)
      {
        yield return new ValidationResult("are you crazy!", new string[] { "SelectedCrust", "SelectedSize" });
      }

      if (SelectedToppings.Count < 2 || SelectedToppings.Count > 5)
      {
        yield return new ValidationResult("are you crazy!", new string[] { "SelectedToppings" });
      }

      //return instance of collection
    }



  }
}