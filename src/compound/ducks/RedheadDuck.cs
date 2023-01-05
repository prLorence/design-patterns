using compound.observer;

namespace compound
{
  public class RedheadDuck : IQuackable
  {
    Observable observable;
    public RedheadDuck()
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