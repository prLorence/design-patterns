using System.Collections;

namespace iterator
{
  public class Waitress
  {
    PancakeHouseMenu pancakeHouseMenu;
    DinerMenu dinerMenu;

    public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
    {
      this.pancakeHouseMenu = pancakeHouseMenu;
      this.dinerMenu = dinerMenu;
    }

    public void printMenu()
    {
      List<MenuItem>.Enumerator pancakeIterator = pancakeHouseMenu.createIterator();
      IEnumerator dinerIterator = dinerMenu.createIterator();

      System.Console.WriteLine("MENU\n--\nBREAKFAST");
      printMenu(pancakeIterator);
      System.Console.WriteLine("\nLUNCH");
      printMenu(dinerIterator);

    }

    private void printMenu(List<MenuItem>.Enumerator iterator)
    {
      while (iterator.MoveNext())
      {
        MenuItem menuItem = iterator.Current;
        System.Console.Write(menuItem.Name + ", ");
        System.Console.Write(menuItem.Price + " -- ");
        System.Console.WriteLine(menuItem.Description);
      }
    }

    private void printMenu(IEnumerator iterator)
    {
      while (iterator.MoveNext())
      {
        MenuItem menuItem = (MenuItem) iterator.Current;
        System.Console.Write(menuItem?.Name + ", ");
        System.Console.Write(menuItem?.Price + " -- ");
        System.Console.WriteLine(menuItem?.Description);
      }
    }

  }
}