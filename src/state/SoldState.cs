namespace state
{
  public class SoldState : IState
  {
    GumballMachine gumballMachine;

    public SoldState(GumballMachine gumballMachine)
    {
      this.gumballMachine = gumballMachine;
    }
    public void dispense()
    {
      gumballMachine.releaseBall();
      if (gumballMachine.getCount() > 0) 
      {
        gumballMachine.setState(gumballMachine.getNoQuarterState());
      }
      else
      {
        System.Console.WriteLine("Oops, out of gumballs");
        gumballMachine.setState(gumballMachine.getSoldOutState());
      }
    }

    public void ejectQuarter()
    {
      System.Console.WriteLine("Sorry, you already turned the crank");
    }

    public void insertQuarter()
    {
      System.Console.WriteLine("Please wait, we're already giving you a gumball");
    }

    public void turnCrank()
    {
      System.Console.WriteLine("Turning twice doesn't get you another gumball!");
    }
  }
}