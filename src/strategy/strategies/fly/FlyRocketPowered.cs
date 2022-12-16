using strategy.behaviors;

namespace strategy.strategies.fly 
{
  public class FlyRocketPowered : IFlyBehavior 
  {
    public void fly() 
    {
      System.Console.WriteLine("Rocket flying");
    }
  }
}