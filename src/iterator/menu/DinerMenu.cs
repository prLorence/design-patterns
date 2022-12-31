using System.Collections;

namespace iterator
{
  public class DinerMenu
  {
    private MenuItem[] menuItems;
    public MenuItem[] MenuItems
    { get {return menuItems;} }

    const int MAX_ITEMS = 6;

    int numberOfItems = 0;

    public DinerMenu()
    {
      menuItems = new MenuItem[MAX_ITEMS];

      addItem("Vegetarian BLT",
          "(Fakin') Bacon with lettuce & tomato on whole wheat",
          true,
          2.99
      );

      addItem("BLT",
          "Bacon with lettuce & tomato on whole wheat",
          false,
          2.99
      );
      
      addItem("Soup of the day",
          "Soup of the day, with a side of potato salad",
          true,
          3.29
      );

      addItem("Hot dog",
          "A hot dog, with sauerkraut, relish, onions, topped with cheese",
          false,
          3.05
      );

      addItem("Steamed Veggies and Brown Rice",
          "Steamed vegetables over brown rice",
          true,
          3.99
      );

      addItem("Spaghetti with marinara sauce",
          "Spaghetti with marinara sauce, and a slice of sourdough bread",
          false,
          3.89
      );
    }

    public void addItem(String name, String description, bool vegetarian, double price)
    {
      MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
      if (numberOfItems >= MAX_ITEMS)
      {
        throw new InvalidOperationException("Menu is full!");
      } 
      else
      {
        menuItems[numberOfItems] = menuItem;
        numberOfItems += 1;
      }
    }

    public IEnumerator createIterator()
    {
      return menuItems.GetEnumerator();
      // return new DinerMenuIterator(menuItems);
    }

  }
}