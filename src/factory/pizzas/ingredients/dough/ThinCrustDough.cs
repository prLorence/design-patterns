using factory.ingredients;

namespace factory.ingredients.dough
{
  class ThinCrustDough : IDough
  {
    public void getDough()
    {
      System.Console.WriteLine("Getting Thin Crust Dough");
    }
  }
}