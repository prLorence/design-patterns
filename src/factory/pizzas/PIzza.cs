// ! no abstract methods thats why c# is not complaining to implement abstract methods.

using factory.ingredients;

namespace factory.pizzas
{
  public abstract class Pizza
  {
    protected IDough dough;
    protected ISauce sauce;
    protected ICheese cheese;
    protected IPepperoni pepperoni;
    protected IClam clam;
    // protected Veggies[] veggies;

    protected String name;

    public abstract void prepare();

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