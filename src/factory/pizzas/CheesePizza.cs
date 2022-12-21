namespace factory.pizzas
{
  class CheesePizza : Pizza
  {
    IPizzaIngredientFactory ingredientFactory;

    public CheesePizza(IPizzaIngredientFactory ingredientFactory)
    {
      this.ingredientFactory = ingredientFactory;
    }

    public override void prepare()
    {
      name = "Cheese Pizza";
      System.Console.WriteLine("Preparing {0}", name);
      dough = ingredientFactory.createDough();
      sauce = ingredientFactory.createSauce();
      cheese = ingredientFactory.createCheese();
    }
  }
}