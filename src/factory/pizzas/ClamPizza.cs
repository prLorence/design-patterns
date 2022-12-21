namespace factory.pizzas
{
  class ClamPizza : Pizza
  {
    IPizzaIngredientFactory ingredientFactory;
    public ClamPizza(IPizzaIngredientFactory ingredientFactory)
    {
      this.ingredientFactory = ingredientFactory;
    }
    public override void prepare()
    {
      System.Console.WriteLine("Preparing {0}", name);
      dough = ingredientFactory.createDough();
      sauce = ingredientFactory.createSauce();
      cheese = ingredientFactory.createCheese();
      clam = ingredientFactory.createClam();
    }
  }
}