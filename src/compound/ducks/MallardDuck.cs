using compound.observer;

namespace compound
{
  public class MallardDuck : IQuackable
  {
    Observable observable;
    public MallardDuck()
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