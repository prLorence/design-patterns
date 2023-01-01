using System.Text;

namespace state
{
  public class GumballMachine
  {
    IState soldOutState;
    IState noQuarterState;
    IState hasQuarterState;
    IState soldState;

    IState state;
    int count = 0;

    public GumballMachine(int numberGumballs)
    {
        soldOutState = new SoldOutState(this);
        noQuarterState = new NoQuarterState(this);
        hasQuarterState = new HasQuarterState(this);
        soldState = new SoldState(this);

        this.count = numberGumballs;

        if (numberGumballs > 0)
        {
            state = noQuarterState;
        } 
        else 
        {
            state = soldOutState;
        }

    }

    public void insertQuarter()
    {
        state.insertQuarter();
    }

    public void ejectQuarter()
    {
        state.ejectQuarter();
    }

    public void turnCrank()
    {
        state.turnCrank();
        state.dispense();
    }

    public void setState(IState state)
    {
        this.state = state;
    }
	public void releaseBall() {
		System.Console.WriteLine("A gumball comes rolling out the slot...");
		if (count > 0) {
			count = count - 1;
		}
	}
 
	public int getCount() {
		return count;
	}
 
    public IState getState() {
        return state;
    }
    public IState getSoldOutState() {
        return soldOutState;
    }

    public IState getNoQuarterState() {
        return noQuarterState;
    }

    public IState getHasQuarterState() {
        return hasQuarterState;
    }

    public IState getSoldState() {
        return soldState;
    }
 
	public String toString() {
		StringBuilder result = new StringBuilder();
		result.Append("\nMighty Gumball, Inc.");
		result.Append("\nJava-enabled Standing Gumball Model #2004");
		result.Append("\nInventory: " + count + " gumball");
		if (count != 1) {
			result.Append("s");
		}
		result.Append("\n");
		result.Append("Machine is " + state + "\n");
		return result.ToString();
	}
  }
}