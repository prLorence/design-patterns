namespace composite
{
  public class Menu : MenuComponent
  {
    List<MenuComponent> menuComponents = new List<MenuComponent>();
    String name;
    String description;

    public Menu(String name, String description)
    {
      this.name = name;
      this.description = description;
    }

    public new void add(MenuComponent menuComponent)
    {
      menuComponents.Add(menuComponent);
    }
    public new void remove(MenuComponent menuComponent)
    {
      menuComponents.Remove(menuComponent);
    }
    
    public new MenuComponent getChild(int i)
    {
      return menuComponents[i];
    }

    public new String getName()
    {
      return name;
    }

    public new String getDescription()
    {
      return description;
    }

    public new void print()
    {
      System.Console.WriteLine("\n{0}", getName());
      System.Console.WriteLine(", {0}", getDescription());
      System.Console.WriteLine("-------------------------------");

      foreach (MenuComponent menuComponent in menuComponents)
      {
        menuComponent.print();
      }
    }
    

  }


}