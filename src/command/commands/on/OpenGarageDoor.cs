using command.commands.items;

namespace command.commands.on
{
  public class OpenGarageDoor : ICommand
  {
    Garage slot;
    public OpenGarageDoor(Garage garage)
    {
      slot = garage;
    }
    public void execute()
    {
      slot.open();
    }
  }
}