using decorator;

namespace decorator.condiments
{
  class Soy : CondimentDecorator
  {
    public Soy (Beverage beverage)
    {
      this.beverage = beverage;
    }
    public override double cost()
    {
      return beverage.cost() + 0.15;
    }

    public override String getDescription()
    {
      return beverage.getDescription() + ", Soy";
    }
  }
}
