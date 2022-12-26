using adapter.duck;
using adapter.turkey;

namespace adapter
{
  public class TurkeyAdapter : IDuck
  {
    ITurkey turkey;

    public TurkeyAdapter(ITurkey turkey)
    {
      this.turkey = turkey;
    }

    public void fly()
    {
      for (int i = 0; i < 3; i ++)
      {
        turkey.fly();
      }
    }

    public void quack()
    {
      turkey.gobble();
    }
  }
}