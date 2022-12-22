
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
      ICheese mozzarella = new MozarellaCheese();
      mozzarella.getCheese();
      return mozzarella;
    }

    public IClam createClam()
    {
      
      IClam frozenCLams = new FrozenClams();
      frozenCLams.getClams();
      return frozenCLams;
    }

    public IDough createDough()
    {
      IDough thickDough = new ThickCrustDough();
      thickDough.getDough();
      return thickDough;
    }

    public IPepperoni createPepperoni()
    {
      IPepperoni pepperoni = new SlicedPepperoni();
      pepperoni.getPepperoni();
      return pepperoni;
    }

    public ISauce createSauce()
    {
      ISauce sauce = new PlumTomatoSauce();
      sauce.getSauce();
      return sauce;
    }

    // public Veggies[] createVeggies()
    // {
    //   Veggies[] veggies = {new Spinach(), new BlackOlives(), new Eggplant()};
    //   return veggies;
    // }
  }
}