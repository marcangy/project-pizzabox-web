using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing
{
  public class PizzaBoxContext : DbContext
  {
    public DbSet<AStore> Stores { get; set; }
    public DbSet<APizza> Pizzas { get; set; }
    public DbSet<ACustomer> Customers { get; set; }
    public DbSet<AOrder> Orders { get; set; }
    public DbSet<Topping> Toppings { get; set; }
    public DbSet<Crust> Crusts { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public PizzaBoxContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<AStore>().HasKey(e => e.EntityID);
      builder.Entity<ChicagoStore>().HasBaseType<AStore>();
      builder.Entity<NewYorkStore>().HasBaseType<AStore>();
      builder.Entity<AStore>().HasMany<AOrder>(s => s.Orders).WithOne(o => o.Store);



      builder.Entity<AOrder>().HasKey(e => e.EntityID);
      builder.Entity<RegOrder>().HasBaseType<AOrder>();
      builder.Entity<AOrder>().HasMany<APizza>(o => o.Pizzas).WithMany(p => p.Orders);

      builder.Entity<ACustomer>().HasKey(e => e.EntityID);
      builder.Entity<RegCustomer>().HasBaseType<ACustomer>();
      builder.Entity<ACustomer>().HasMany<AOrder>().WithOne();

      builder.Entity<APizza>().HasKey(e => e.EntityID);
      builder.Entity<CustomPizza>().HasBaseType<APizza>();
      builder.Entity<MeatLoversPizza>().HasBaseType<APizza>();
      builder.Entity<VeggiePizza>().HasBaseType<APizza>();
      builder.Entity<CheesePizza>().HasBaseType<APizza>();


      builder.Entity<Topping>().HasKey(e => e.EntityID);

      builder.Entity<APizza>().HasMany<Topping>(p => p.Toppings).WithMany(t => t.pizzas);



      builder.Entity<Crust>().HasKey(e => e.EntityID);
      builder.Entity<Crust>().HasMany<APizza>().WithOne(p => p.Crust);

      builder.Entity<Size>().HasKey(e => e.EntityID);
      builder.Entity<Size>().HasMany<APizza>().WithOne(p => p.Size);
      OnDataSeeding(builder);

    }
    private void OnDataSeeding(ModelBuilder builder)
    {

      builder.Entity<NewYorkStore>().HasData(new NewYorkStore[] { new NewYorkStore() { Name = "Da Best NY Pizza", EntityID = 1 } });
      builder.Entity<ChicagoStore>().HasData(new ChicagoStore[] { new ChicagoStore() { Name = "Chitown Pizzeria", EntityID = 2 } });


      builder.Entity<RegCustomer>().HasData(new RegCustomer[] { new RegCustomer() { Name = "Samual Adams", EntityID = 1 } });

      builder.Entity<Crust>().HasData(new[]
      {
        new Crust() { EntityID = 1, Name = "Original" },
        new Crust() { EntityID = 2, Name = "Stuffed" },
        new Crust() { EntityID = 3, Name = "Thin" },
      });

      builder.Entity<Size>().HasData(new[]
      {
        new Size() { EntityID = 1, Name = "Small", Price =7.5 },
        new Size() { EntityID = 2, Name = "Medium", Price =9.5},
        new Size() { EntityID = 3, Name = "Large", Price = 11.5}
      });

      builder.Entity<Topping>().HasData(new[]
      {

        new Topping() { EntityID = 1, Name = "Cheese" },
        new Topping() { EntityID = 2, Name = "Bacon" },
        new Topping() { EntityID = 3, Name = "Ham" },
        new Topping() { EntityID = 4, Name = "Mushroom" },
        new Topping() { EntityID = 5, Name = "Beef" },
        new Topping() { EntityID = 6, Name = "Spinach" },
        new Topping() { EntityID = 7, Name = "Pepperoni" },
        new Topping() { EntityID = 8, Name = "Olives" },
        new Topping() { EntityID = 9, Name = "Sauce" }

      });




    }
  }
}