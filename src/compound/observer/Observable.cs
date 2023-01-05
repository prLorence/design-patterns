using System.Collections;

namespace compound.observer
{
  public class Observable : IQuackObservable
  {
    List<IObserver> observers = new List<IObserver>();
    IQuackObservable duck;

    public Observable(IQuackObservable duck)
    {
      this.duck = duck;
    }
    public void notifyObservers()
    {
      IEnumerator iterator = observers.GetEnumerator();
      while (iterator.MoveNext())
      {
        IObserver observer = (IObserver)iterator.Current;
        observer.update(duck);
      }

    }

    public void registerObserver(IObserver observer)
    {
      observers.Add(observer);
    }
  }


}