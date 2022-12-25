using command.commands.items;

namespace command.commands.off
{
  public class CloseGarageDoor : ICommand
  {
    Garage garage;
    
    public CloseGarageDoor(Garage garage)
    {
      this.garage = garage;
    }

    public void execute()
    {
      garage.close();
    }
  }
}