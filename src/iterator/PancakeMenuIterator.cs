namespace iterator
{
  public class PancakeMenuIterator : IIterator
  {
    List<MenuItem> items;
    int position = 0;

    public PancakeMenuIterator(List<MenuItem> items)
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
      if (position == items.Count || items[position] == null)
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