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
    public List<Crust> Crusts { get; set; }
    public List<Size> Sizes { get; set; }
    public List<Topping> Toppings { get; set; }


    [Required(ErrorMessage = "selected crust")]
    [DataType(DataType.Text)]
    public string SelectedCrust { get; set; }

    [Required(ErrorMessage = "selected size")]
    [DataType(DataType.Text)]
    public string SelectedSize { get; set; }

    [Required(ErrorMessage = "selected topping")]
    public List<string> SelectedToppings { get; set; }

    public void Load(UnitOfWork unitOfWork)
    {
      Crusts = unitOfWork.Crusts.Select(c => c.EntityID > 0).ToList();
      Sizes = unitOfWork.Sizes.Select(c => c.EntityID > 0).ToList();
      Toppings = unitOfWork.Toppings.Select(c => c.EntityID > 0).ToList();

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