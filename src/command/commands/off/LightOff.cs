using command.commands.items;

namespace command.commands.off
{
  public class LightOff : ICommand
  {
    Light light;

    public LightOff(Light light)
    {
      this.light = light;
    }

    public void execute()
    {
      light.off();
    }
  }
}