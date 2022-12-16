using strategy.behaviors;

namespace strategy.strategies.fly 
{
  class FlyNoWay : IFlyBehavior 
  {
    public void fly() 
    {
      Console.WriteLine("Not Flying");
    }
  }
}