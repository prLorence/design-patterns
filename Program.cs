// See https://aka.ms/new-console-template for more information

using strategy;
using strategy.ducks;
using strategy.strategies.fly;

using observer.classes;

using decorator;
using decorator.beverages;
using decorator.condiments;

using factory;
using factory.pizzas;
using factory.ingredient_factory;

using command;
using command.commands;

namespace design_patterns
{
  class Program 
  {
    static  void Main(string[] args) 
    {
      // ! Strategy Pattern
      // Duck mallard = new MallardDuck();
      // mallard.performFly();
      // mallard.performQuack();
      
      // Duck model = new ModelDuck();
      // model.performFly();
      // model.setFlyingBehavior(new FlyRocketPowered());
      // model.performFly();
      // model.performQuack();

      // ! Observer Pattern
      // WeatherData weatherData = new WeatherData();
      // CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
      
      // weatherData.setMeasurements(80, 65, 30.4f);
      // weatherData.setMeasurements(82, 70, 29.2f);
      // weatherData.setMeasurements(78, 90, 29.2f);

      // ! Decorator Pattern
      // Beverage beverage = new Espresso();
      // System.Console.WriteLine("{0} ${1}", beverage.getDescription(), beverage.cost());

      // Beverage beverage2 = new DarkRoast();
      // beverage2 = new Mocha(beverage2);
      // beverage2 = new Mocha(beverage2);
      // beverage2 = new Whip(beverage2);
      // System.Console.WriteLine("{0} ${1}", beverage2.getDescription(), beverage2.cost());

      // Beverage beverage3 = new HouseBlend();
      // beverage3 = new Soy(beverage3);
      // beverage3 = new Mocha(beverage3);
      // beverage3 = new Whip(beverage3);
      // System.Console.WriteLine("{0} ${1}", beverage3.getDescription(), beverage3.cost());

      // ! Factory Pattern
      // PizzaStore nyStore = new NYPizzaStore();
      // PizzaStore chicagoStore = new ChicagoPizzaStore();

      // Pizza pizza = nyStore.orderPizza("cheese");
      // System.Console.WriteLine("Paul ordered a {0}\n", pizza.getName());

      // pizza = chicagoStore.orderPizza("cheese");
      // System.Console.WriteLine("Paul ordered a {0}\n", pizza.getName());

      // IPizzaIngredientFactory pizzaFactory = new NYPizzaIngredientFactory();
      // IPizzaIngredientFactory chicagoFactory = new ChicagoPizzaIngredientFactory();
      // CheesePizza nyCheesePizza = new CheesePizza(pizzaFactory);
      // CheesePizza chCheesePizza = new CheesePizza(chicagoFactory);
      // nyCheesePizza.prepare();
      // chCheesePizza.prepare();

      // ! Command Pattern     
      RemoteControl remote = new RemoteControl();
      Light light = new Light();
      Garage garage = new Garage();
      LightOn lightOn = new LightOn(light);
      OpenGarageDoor openGarage = new OpenGarageDoor(garage);


      remote.setCommand(lightOn);
      remote.buttonPress();
      remote.setCommand(openGarage);
      remote.buttonPress();
    }
  }
}
