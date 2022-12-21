using factory.ingredients;

namespace factory.ingredients.dough
{
  class ThickCrustDough : IDough
  {
    public void getDough()
    {
      System.Console.WriteLine("Getting Thick Crust Dough");
    }
  }
}