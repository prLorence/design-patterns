using strategy.behaviors;

namespace strategy.strategies.fly 
{
  class FlyWithWings : IFlyBehavior
  {
    public void fly()
    {
      Console.WriteLine("Flying With Wings");
    }
  }
}