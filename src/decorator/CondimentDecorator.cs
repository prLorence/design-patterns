namespace decorator
{
  abstract class CondimentDecorator : Beverage
  {
    Beverage bev;

    public Beverage beverage
    { get {return bev; } set { bev = value; } }
    public abstract String getDescription();
  }
}