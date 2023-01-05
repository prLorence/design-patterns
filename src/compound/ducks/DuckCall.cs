using compound.observer;

namespace compound
{
  public class DuckCall : IQuackable
  {
    Observable observable;
    public DuckCall()
    {
      observable = new Observable(this);
    }

    public void registerObserver(IObserver observer)
    {
      observable.registerObserver(observer);
    }
    public void notifyObservers()
    {
      observable.notifyObservers();
    }

    public void quack()
    {
      System.Console.WriteLine("Quack");
      notifyObservers();
    }
  }

}