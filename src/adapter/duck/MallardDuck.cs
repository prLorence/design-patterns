namespace adapter.duck
{
  public class MallardDuck : IDuck
  {
    public void fly()
    {
      System.Console.WriteLine("I'm a flying duck!");
    }

    public void quack()
    {
      System.Console.WriteLine("I'm quacking!");
    }
  }
}