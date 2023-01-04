using state;

namespace proxy
{
  public class GumballMonitor
  {
    GumballMachine gumballMachine;

    public GumballMonitor(GumballMachine gumballMachine)
    {
      this.gumballMachine = gumballMachine;
    }

    public void report()
    {
      System.Console.WriteLine("Gumball Machine: " + gumballMachine.getLocation());
      System.Console.WriteLine("Current Inventory: " + gumballMachine.getCount());
      System.Console.WriteLine("Current Stats: " + gumballMachine.getState());
    }
  }
  
}