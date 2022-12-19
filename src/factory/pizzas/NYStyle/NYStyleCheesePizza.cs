namespace factory.pizzas.NYStyle
{
  public class NYStyleCheesePizza : Pizza
  {
    public NYStyleCheesePizza() : base()
    {
      name = "NY Style Sauce and Cheese Pizza";
      dough = "Thin Crust Dough";
      sauce = "Marinara Sauce";

      toppings.Add("Grated Reggiano Cheese");
    }
  }
}