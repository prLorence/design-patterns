using decorator;

namespace decorator.condiments
{
  class Whip : CondimentDecorator
  {
    public Whip (Beverage beverage)
    {
      this.beverage = beverage;
    }
    public override double cost()
    {
      return beverage.cost() + 0.10;
    }

    public override String getDescription()
    {
      return beverage.getDescription() + ", Whip Cream";
    }
  }
}
