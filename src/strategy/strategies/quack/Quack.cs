using strategy.behaviors;

namespace strategy.behaviors 
{
  class Quack : IQuackBehavior
  {
    public void quack() 
    {
      Console.WriteLine("Quack");
    }
  }
}