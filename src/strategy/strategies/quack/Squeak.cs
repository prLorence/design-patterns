using strategy.behaviors;

namespace strategy.strategies.quack 
{
  class Squeak : IQuackBehavior 
  {
    public void quack() 
    {
      System.Console.WriteLine("Squeak");
    }
  }
}