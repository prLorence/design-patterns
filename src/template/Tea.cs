namespace template
{
  public class Tea : CaffeineBeverage
  {
    protected override void addCondiments()
    {
      System.Console.WriteLine("Adding lemon");
    }

    protected override void brew()
    {
      System.Console.WriteLine("Steeping the tea");
    }
  }
}