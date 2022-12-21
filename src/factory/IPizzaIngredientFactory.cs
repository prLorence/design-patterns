using factory.ingredients;

namespace factory
{
  public interface IPizzaIngredientFactory
  {
    public IDough createDough();
    public ISauce createSauce();
    public ICheese createCheese();
    // public Veggies[] createVeggies();
    public IPepperoni createPepperoni();
    public IClam createClam();
  }
}