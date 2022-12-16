using strategy.behaviors;
using strategy.strategies.fly;
using strategy.strategies.quack;

namespace strategy
{
  // HAS-A relationship with flyingBehavior and quackingBehavior
  public class Duck 
  {
    protected static IFlyBehavior flyingBehavior;
    protected static IQuackBehavior quackingBehavior;
    public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) 
    {
      flyingBehavior = flyBehavior;
      quackingBehavior = quackBehavior;
    }

    public void performFly() {
      flyingBehavior.fly();
    }

    public void performQuack() {
      quackingBehavior.quack();
    }
    
    public void setFlyingBehavior(IFlyBehavior flyBehavior) {
      flyingBehavior = flyBehavior;
    }

    public void setQuackingBehavior(IQuackBehavior quackBehavior) {
      quackingBehavior = quackBehavior;
    }
  }
}