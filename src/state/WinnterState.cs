namespace state
{
  public class WinnerState : IState
  {
    GumballMachine gumballMachine;

    public WinnerState(GumballMachine gumballMachine)
    {
      this.gumballMachine = gumballMachine;
    }
    public void dispense()
    {
      throw new NotImplementedException();
    }

    public void ejectQuarter()
    {
      throw new NotImplementedException();
    }

    public void insertQuarter()
    {
      throw new NotImplementedException();
    }

    public void turnCrank()
    {
      throw new NotImplementedException();
    }
  }
}
