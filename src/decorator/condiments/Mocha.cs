using decorator;

namespace decorator.condiments
{
  class Mocha : CondimentDecorator
  {
    public Mocha (Beverage beverage)
    {
      this.beverage = beverage;
    }

    public override double cost()
    {
      return beverage.cost() + 0.20;
    }

    public override String getDescription()
    {
      return beverage.getDescription() + ", Mocha";
    }
  }
}