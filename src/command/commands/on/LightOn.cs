using command.commands.items;

namespace command.commands.on
{
  public class LightOn: ICommand
  {
    Light light;

    public LightOn(Light light)
    {
      this.light = light;
    }

    public void execute()
    {
      light.on();
    }
  }
}