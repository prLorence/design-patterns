namespace state
{
  public class NoQuarterState : IState
  {
    GumballMachine gumballMachine;

    public NoQuarterState(GumballMachine gumballMachine)
    {
      this.gumballMachine = gumballMachine;
    }

    public void dispense()
    {
      System.Console.WriteLine("You need to pay first");
    }

    public void ejectQuarter()
    {
      System.Console.WriteLine("You haven't inserted a quarter");
    }

    public void insertQuarter()
    {
      System.Console.WriteLine("You inserted a quarter");
    }

    public void turnCrank()
    { 
      System.Console.WriteLine("You turned, but there's no quarter");
    }
  }
}