namespace state
{
  public class HasQuarterState : IState
  {
    GumballMachine gumballMachine;

    public HasQuarterState(GumballMachine gumballMachine)
    {
      this.gumballMachine = gumballMachine;
    }
    public void dispense()
    {
      System.Console.WriteLine("No gumball dispensed");
    }

    public void ejectQuarter()
    {
      System.Console.WriteLine("Quarter returned");
      gumballMachine.setState(gumballMachine.getNoQuarterState());
    }

    public void insertQuarter()
    {
      System.Console.WriteLine("You can't insert another quarter");
    }

    public void turnCrank()
    {
      System.Console.WriteLine("You turned...");
      gumballMachine.setState(gumballMachine.getSoldState());
    }
  }
}