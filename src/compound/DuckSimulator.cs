using compound.composite;
using compound.decorator;
using compound.factory;

namespace compound
{
  public class DuckSimulator
  {

    public void Run()
    {
      DuckSimulator simulator = new DuckSimulator();

      AbstractDuckFactory duckFactory = new CountingDuckFactory();

      simulator.simulate(duckFactory);
    }

    void simulate(AbstractDuckFactory duckFactory)
    {
      IQuackable mallardDuck = duckFactory.createMallardDuck();
      IQuackable redheadDuck = duckFactory.createRedheadDuck();
      IQuackable duckCall = duckFactory.createDuckCall();
      IQuackable rubberDuck = duckFactory.createRubberDuck();
      IQuackable quackableGoose = new GooseAdapter(new Goose());

      Flock flockOfDucks = new Flock();

      flockOfDucks.Add(mallardDuck);
      flockOfDucks.Add(redheadDuck);
      flockOfDucks.Add(duckCall);
      flockOfDucks.Add(rubberDuck);

      Flock mallardFlock = new Flock();

      IQuackable mallardDuckOne = duckFactory.createMallardDuck();
      IQuackable mallardDuckTwo = duckFactory.createMallardDuck();
      IQuackable mallardDuckThree = duckFactory.createMallardDuck();
      IQuackable mallardDuckFour = duckFactory.createMallardDuck();

      mallardFlock.Add(mallardDuckOne);
      mallardFlock.Add(mallardDuckTwo);
      mallardFlock.Add(mallardDuckThree);
      mallardFlock.Add(mallardDuckFour);

      flockOfDucks.Add(mallardFlock);


      System.Console.WriteLine("\nSimulate Whole Flock");
      simulate(flockOfDucks);

      System.Console.WriteLine("\nSimulate Mallard Flock");
      simulate(mallardFlock);

      System.Console.WriteLine("\nDuck simulator: With Observer");
      Quackologist quackologist = new Quackologist();
      flockOfDucks.registerObserver(quackologist);

      System.Console.WriteLine("\nDuck Simulator");

      simulate(mallardDuck);
      simulate(redheadDuck);
      simulate(duckCall);
      simulate(rubberDuck);
      simulate(quackableGoose);

      System.Console.WriteLine("\nThe ducks quacked {0} times", QuackCounter.numberOfQuacks);

    }

    void simulate(IQuackable duck)
    {
      duck.quack();
    }
  
  }

}