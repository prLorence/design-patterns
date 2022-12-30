using System.Collections;

namespace iterator
{
  public class PancakeHouseMenu
  {
    private List<MenuItem> menuItems;

    public List<MenuItem> MenuItems 
    { get {return menuItems;} }

    public PancakeHouseMenu()
    {
      menuItems = new List<MenuItem>();

      addItem("K&B's Pancake Breakfast", 
        "Pancakes with scrambled eggs and toast",
        true,
        2.99);

      addItem("Regular Pancake Breakfast", 
        "Pancakes with fried eggs, sausage",
        false,
        2.99);

      addItem("Blueberry Pancake ", 
        "Pancakes made with fresh blueberries",
        true,
        3.49);

      addItem("Waffles", 
        "Waffles with your choice of blueberries or strawberries",
        true,
        3.59);
    }

    public void addItem(String name, String description, bool vegetarian, double price)
    {
      MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
      menuItems.Add(menuItem);
    }

    public IEnumerator createIterator()
    {
      return menuItems.GetEnumerator();
    }
  }
}