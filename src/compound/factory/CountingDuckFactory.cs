using compound.decorator;

namespace compound.factory
{
  public class CountingDuckFactory : AbstractDuckFactory
  {
    public override IQuackable createDuckCall()
    {
      return new QuackCounter(new DuckCall());
    }

    public override IQuackable createMallardDuck()
    {
      return new QuackCounter(new MallardDuck());
    }

    public override IQuackable createRedheadDuck()
    {
      return new QuackCounter(new RedheadDuck());
    }

    public override IQuackable createRubberDuck()
    {
      return new QuackCounter(new RubberDuck());
    }
  }

}