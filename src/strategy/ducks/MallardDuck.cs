using strategy.behaviors;
using strategy.strategies.fly;

namespace strategy.ducks 
{
  // IS-A relationship from Duck class
  class MallardDuck : Duck 
  {
    public MallardDuck() : base(flyingBehavior, quackingBehavior) {
      flyingBehavior = new FlyWithWings();
      quackingBehavior = new Quack();
    }

    public void display() 
    {
      System.Console.WriteLine("\nMallard Duck");
    }
  }
}