namespace singleton
{
  class ChocoBoiler
  {
    private bool empty;
    private bool boiled;

    private static ChocoBoiler uniqueInstance;

    private ChocoBoiler()
    {
      empty = true;
      boiled = false;
    }

    public static ChocoBoiler getInstance()
    {
      if (uniqueInstance == null) 
      {
        uniqueInstance = new ChocoBoiler();
      }
      return uniqueInstance;
    }

    public void fill()
    {
      if (isEmpty()) 
      {
        empty = false;
        boiled = false;
      }
    }

    public void drain()
    {
      if (isEmpty() && isBoiled()) 
      {
        empty = true;
      }
    }

    public void boil()
    {
      if (!isEmpty() && isBoiled()) 
      {
        boiled = true;
      }
    }

    public bool isEmpty()
    {
      return empty;
    }


    public bool isBoiled()
    {
      return boiled;
    }
  }
}