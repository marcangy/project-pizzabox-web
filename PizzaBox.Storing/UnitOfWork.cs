using PizzaBox.Storing.Repositories;

namespace PizzaBox.Storing
{
  public class UnitOfWork
  {
    public CustomerRepository Customers { get; }
    public StoreRepository Stores { get; }
    public CrustRepository Crusts { get; }
    public SizeRepository Sizes { get; }
    public ToppingRepository Toppings { get; }
    public PizzaRepository Pizzas { get; }
    public OrderRepository Orders { get; }
    private PizzaBoxContext _context { get; }


    public UnitOfWork(PizzaBoxContext context)
    {
      _context = context;
      Crusts = new CrustRepository(_context);
      Sizes = new SizeRepository(_context);
      Toppings = new ToppingRepository(_context);
      Pizzas = new PizzaRepository(_context);
      Orders = new OrderRepository(_context);
      Customers = new CustomerRepository(_context);
      Stores = new StoreRepository(_context);
    }
    public void Save()
    {
      _context.SaveChanges();
    }
  }
}