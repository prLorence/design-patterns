using compound.observer;

namespace compound
{
  public class RubberDuck : IQuackable
  {
    Observable observable;
    public RubberDuck()
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