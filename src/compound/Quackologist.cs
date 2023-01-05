using compound.observer;

namespace compound
{
  public class Quackologist : IObserver
  {

    public void update(IQuackObservable duck)
    {
      System.Console.WriteLine("Quackologist: {0} just quacked", duck.GetType());
    }
  }
  
}