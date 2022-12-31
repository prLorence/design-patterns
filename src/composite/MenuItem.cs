namespace composite
{
  public class MenuItem : MenuComponent
  {
    String name;
    String description;
    bool vegetarian;
    double price;

    public MenuItem(String name, String description, bool vegetarian, double price)
    {
      this.name = name;
      this.description = description;
      this.vegetarian = vegetarian;
      this.price = price;
    }

    public new String getName()
    {
      return name;
    }

    public new String getDescription()
    {
      return description;
    }

    public new double getPrice()
    {
      return price;
    }

    public new bool isVegetarian()
    {
      return vegetarian;
    }

    public new void print()
    {
      System.Console.WriteLine(" " + getName());
      if(isVegetarian())
      {
        System.Console.Write("(v)");
      }
      System.Console.WriteLine(" " + getPrice());
      System.Console.WriteLine("      --" + getDescription());
    }


  }
}