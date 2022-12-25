using command.commands;

namespace command
{
  public class RemoteControl
  {
    ICommand[] onCommands;
    ICommand[] offCommands;

    public RemoteControl() 
    {
      onCommands = new ICommand[7];
      offCommands = new ICommand[7];

      ICommand noCommand = NoCommand.getInstance();

      for (int i = 0; i < 7; i++)
      {
        onCommands[i] = noCommand;
        offCommands[i] = noCommand;
      }
    }

    public void setCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
      onCommands[slot] = onCommand;
      offCommands[slot] = offCommand;
    }

    public void onButtonPress(int slot)
    {
      onCommands[slot].execute();
    }

    public void offButtonPress(int slot)
    {
      offCommands[slot].execute();
    }
  }
}