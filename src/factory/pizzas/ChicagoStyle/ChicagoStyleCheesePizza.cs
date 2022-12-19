namespace factory.pizzas.ChicagoStyle
{
  class ChicagoStyleCheesePizza : Pizza
  {
    public ChicagoStyleCheesePizza() : base()
    {
      name = "Chicago Style Deep Dish Cheese Pizza";
      dough = "Extra Thick Crust Dough";
      sauce = "Plum Tomato Sauce";

      toppings.Add("Shredded Mozzarella Cheese");
    }

    new void cut () 
    {
      System.Console.WriteLine("Cutting pizza into square slices...");
    }
  }
}