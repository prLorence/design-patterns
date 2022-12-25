using System.Text;
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

    public String toString()
    {
      StringBuilder stringBuff = new StringBuilder();
      stringBuff.Append("\n------- Remote Control -------\n");
      for (int i = 0; i < onCommands.Length; i++)
      {
        stringBuff.Append(
          String.Format("[Slot {0}]\t{1}\t\t\t{2}\n", i, onCommands[i].GetType().Name, offCommands[i].GetType().Name)
        );
      }
      return stringBuff.ToString(); 
    }
  }
}