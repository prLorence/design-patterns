
using factory.ingredients;
using factory.ingredients.clams;
using factory.ingredients.cheese;
using factory.ingredients.dough;
using factory.ingredients.sauce;
using factory.ingredients.pepperoni;

namespace factory.ingredient_factory
{
  class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
  {
    public ICheese createCheese()
    {
      return new MozarellaCheese();
    }

    public IClam createClam()
    {
      return new FrozenClams();
    }

    public IDough createDough()
    {
      return new ThickCrustDough();
    }

    public IPepperoni createPepperoni()
    {
      return new SlicedPepperoni();
    }

    public ISauce createSauce()
    {
      return new PlumTomatoSauce();
    }

    // public Veggies[] createVeggies()
    // {
    //   Veggies[] veggies = {new Spinach(), new BlackOlives(), new Eggplant()};
    //   return veggies;
    // }
  }
}