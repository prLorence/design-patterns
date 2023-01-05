namespace compound.observer
{
  public interface IQuackObservable
  {
    void registerObserver(IObserver observer);
    void notifyObservers();
  }
  
}