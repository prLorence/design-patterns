using System.Collections;
using compound.observer;

namespace compound.composite
{
  public class Flock : IQuackable
  {
    Observable observable;
    List<IQuackable> quackers = new List<IQuackable>();

    public void Add(IQuackable quacker)
    {
      quackers.Add(quacker);
      observable = new Observable(this);
    }

    public void notifyObservers()
    {
      observable.notifyObservers();
    }

    public void quack()
    {
      IEnumerator iterator = quackers.GetEnumerator();
      while (iterator.MoveNext())
      {
        IQuackable quacker = (IQuackable)iterator.Current;
        quacker.quack();
        quacker.notifyObservers();
      }
    }

    public void registerObserver(IObserver observer)
    {
      observable.registerObserver(observer);
    }
  }
  
}