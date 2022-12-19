using factory.pizzas;

/**
  in this pattern we only have creator and product classes.
  in this case:
  PizzaStore = Creator
  Pizza = Product
*/

namespace factory
{
  public abstract class PizzaStore 
  {
    public Pizza orderPizza(String type)
    {
      Pizza pizza;

      pizza = CreatePizza(type);

      pizza.prepare();
      pizza.bake();
      pizza.cut();
      pizza.box();

      return pizza;
    }

    // factory method for making pizzas
    
    protected abstract Pizza CreatePizza(String type);

  }
}