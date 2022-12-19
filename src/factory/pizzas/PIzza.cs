// ! no abstract methods thats why c# is not complaining to implement abstract methods.

namespace factory.pizzas
{
  public abstract class Pizza
  {
    protected String name;
    protected String dough;
    protected String sauce;
    protected List<String> toppings = new List<String>();

    public void prepare() 
    {
      System.Console.WriteLine("Preparing: {0}", name);
      System.Console.WriteLine("Tossing dough...");
      System.Console.WriteLine("Adding sauce...");
      System.Console.WriteLine("Adding toppings...");
      foreach (String topping in toppings)
      {
        System.Console.WriteLine("      {0}", topping);
      }
    }

    public void bake()
    {
      System.Console.WriteLine("Baking for 25 minutes at 350 degrees");
    }

    public void cut()
    {
      System.Console.WriteLine("Cutting pizza in to slices");
    }

    public void box()
    {
      System.Console.WriteLine("Place pizza in official PizzaStore box");
    }

    public String getName()
    {
      return name;
    }
  }
}