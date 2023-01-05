using compound.observer;

namespace compound
{
  public class GooseAdapter : IQuackable
  {
    Goose goose;
    public GooseAdapter(Goose goose)
    {
      this.goose = goose;
    }

    public void notifyObservers()
    {
      throw new NotImplementedException();
    }

    public void quack()
    {
      goose.honk();
    }

    public void registerObserver(IObserver observer)
    {
      throw new NotImplementedException();
    }
  }
}