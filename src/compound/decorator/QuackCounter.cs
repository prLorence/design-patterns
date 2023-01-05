using compound.observer;

namespace compound.decorator
{
  public class QuackCounter : IQuackable
  {
    IQuackable duck;
    Observable observable;
    public static int numberOfQuacks {get; set;}

    public QuackCounter(IQuackable duck)
    {
      this.duck = duck;
      observable = new Observable(this);
    }

    public void quack()
    {
      duck.quack();
      numberOfQuacks++;
      notifyObservers();
    }

    public void registerObserver(IObserver observer)
    {
      observable.registerObserver(observer);
    }

    public void notifyObservers()
    {
      observable.notifyObservers();
    }
  }
  
}