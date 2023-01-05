using compound.observer;

namespace compound
{
  public interface IQuackable : IQuackObservable
  {
    public void quack();
  }
}