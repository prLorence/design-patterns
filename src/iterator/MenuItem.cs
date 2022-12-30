namespace iterator
{
  public class MenuItem
  {
    private String name;
    private String description;
    private bool vegetarian;
    private double price;

    public MenuItem(String name, String description, bool vegetarian, double price)
    {
      this.name = name;
      this.description = description;
      this.vegetarian = vegetarian;
      this.price = price;
    }

    public String Name 
    { get {return name;} }
    public String Description 
    { get {return description;} }
    public bool Vegetarian 
    { get {return vegetarian;} }
    public double Price 
    { get {return price;} }

  }
}