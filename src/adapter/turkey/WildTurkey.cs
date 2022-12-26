namespace adapter.turkey
{
  public class WildTurkey : ITurkey
  {
    public void fly()
    {
      System.Console.WriteLine("Im a flying turkey!");
    }

    public void gobble()
    {
      System.Console.WriteLine("I'm gobbling!");
    }
  }
}