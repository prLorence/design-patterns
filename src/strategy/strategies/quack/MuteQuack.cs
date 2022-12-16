using strategy.behaviors;


namespace strategy.strategies.quack
{
  class MuteQuack : IQuackBehavior 
  {
    public void quack() 
    {
      System.Console.WriteLine("...");
    }
  }
}