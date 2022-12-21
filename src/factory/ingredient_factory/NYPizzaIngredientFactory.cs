// using factory.pizzas.ingredients;

using factory.ingredients;
using factory.ingredients.clams;
using factory.ingredients.cheese;
using factory.ingredients.dough;
using factory.ingredients.sauce;
using factory.ingredients.pepperoni;


namespace factory.ingredient_factory
{
  class NYPizzaIngredientFactory : IPizzaIngredientFactory
  {
    public ICheese createCheese()
    {
      ReggianoCheese reggianoCheese = new ReggianoCheese();
      reggianoCheese.getCheese();
      return reggianoCheese;
    }

    public IClam createClam()
    {
      FreshClams freshClams = new FreshClams();
      freshClams.getClams();
      return freshClams;
    }
    public IDough createDough()
    {
      ThinCrustDough thinCrustDough = new ThinCrustDough();
      thinCrustDough.getDough();
      return thinCrustDough;
    }

    public IPepperoni createPepperoni()
    {
      SlicedPepperoni slicedPepperoni = new SlicedPepperoni();
      slicedPepperoni.getPepperoni();
      return slicedPepperoni;
    }

    public ISauce createSauce()
    {
      MarinaraSauce marinaraSauce = new MarinaraSauce();
      marinaraSauce.getSauce();
      return marinaraSauce;
    }

    // public Veggies[] createVeggies()
    // {
    //   Veggies[] veggies = {new Garlic(), new Onion(), new Mushroom(), new RedPepper()};
    //   return veggies;
    // }
  }
}