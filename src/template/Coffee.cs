namespace template
{
  public class Coffee : CaffeineBeverage
  {

    protected override void brew()
    {
      System.Console.WriteLine("Dripping Coffee through filter");
    }

    protected override void addCondiments()
    {
      System.Console.WriteLine("Adding sugar and milk");
    }

  }
}