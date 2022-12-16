using strategy.behaviors;
using strategy.strategies.fly;
using strategy.strategies.quack;

namespace strategy.ducks 
{
  // IS-A relationship to Duck
  class ModelDuck : Duck 
  {
    public ModelDuck() : base(flyingBehavior, quackingBehavior) {
      flyingBehavior = new FlyNoWay();
      quackingBehavior = new MuteQuack();
    }

    public void display() 
    {
      System.Console.WriteLine("Model Duck");
    }
  }
}