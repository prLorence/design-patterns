// See https://aka.ms/new-console-template for more information

using strategy;
using strategy.ducks;
using strategy.strategies.fly;

namespace design_patterns
{
  class Program 
  {
    static  void Main(string[] args) 
    {
      // Strategy Pattern
      Duck mallard = new MallardDuck();
      mallard.performFly();
      mallard.performQuack();
      
      Duck model = new ModelDuck();
      model.performFly();
      model.setFlyingBehavior(new FlyRocketPowered());
      model.performFly();
      model.performQuack();
    }
  }
}
