namespace template
{
  public abstract class CaffeineBeverage
  {
    void prepareRecipe()
    {
      boilWater();
      brew();
      pourInCup();
      addCondiments();
    }
    protected abstract void brew();
    protected abstract void addCondiments();

    public void boilWater()
    {
      System.Console.WriteLine("Boiling water");
    }

    public void pourInCup()
    {
      System.Console.WriteLine("Pouring into cup");
    }

  }
}