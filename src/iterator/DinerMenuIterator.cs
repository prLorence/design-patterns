namespace iterator
{
  public class DinerMenuIterator : IIterator
  {
    MenuItem[] items;
    int position = 0;

    public DinerMenuIterator(MenuItem[] items)
    {
      this.items = items;
    }
    public MenuItem next()
    {
      MenuItem menuItem = items[position];
      position++;
      return menuItem;
    }

    public bool hasNext()
    {
      if (position >= items.Length || items[position].Equals(null))
      {
        return false;
      }
      else 
      {
        return true;
      }
    }

  }
}