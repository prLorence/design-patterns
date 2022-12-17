// See https://aka.ms/new-console-template for more information

using strategy;
using strategy.ducks;
using strategy.strategies.fly;

using observer.classes;

namespace design_patterns
{
  class Program 
  {
    static  void Main(string[] args) 
    {
      // Strategy Pattern
      // Duck mallard = new MallardDuck();
      // mallard.performFly();
      // mallard.performQuack();
      
      // Duck model = new ModelDuck();
      // model.performFly();
      // model.setFlyingBehavior(new FlyRocketPowered());
      // model.performFly();
      // model.performQuack();

      // Observer Pattern
      WeatherData weatherData = new WeatherData();
      CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
      
      weatherData.setMeasurements(80, 65, 30.4f);
      weatherData.setMeasurements(82, 70, 29.2f);
      weatherData.setMeasurements(78, 90, 29.2f);

    }
  }
}
