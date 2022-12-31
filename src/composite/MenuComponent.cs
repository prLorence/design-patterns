namespace composite
{
  public abstract class MenuComponent
  {
    public void add(MenuComponent menuComponent)
    {
      throw new NotSupportedException();
    }
    public void remove(MenuComponent menuComponent)
    {
      throw new NotSupportedException();
    }
    public MenuComponent getChild(int i)
    {
      throw new NotSupportedException();
    }
    public String getName()
    {
      throw new NotSupportedException();
    }
    public String getDescription()
    {
      throw new NotSupportedException();
    }
    public double getPrice()
    {
      throw new NotSupportedException();
    }
    public bool isVegetarian()
    {
      throw new NotSupportedException();
    }
    public void print()
    {
      throw new NotSupportedException();
    }
  }
}