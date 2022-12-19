using factory.pizzas;
using factory.pizzas.ChicagoStyle;

namespace factory.pizza_stores
{
  class ChicagoPizzaStore : PizzaStore
  {
    protected override Pizza CreatePizza(String item)
    {
      if (item.Equals("cheese")) return new ChicagoStyleCheesePizza();
      // else if (item.Equals("veggie")) return new NYStyleVeggiePizza();
      // else if (item.Equals("clam")) return new NYStyleClamPizza();
      // else if (item.Equals("pepperoni")) return new NYStylePepperoniPizza();
      else return null;
    }
  }
}