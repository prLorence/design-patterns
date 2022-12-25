namespace command.commands
{
  public class NoCommand : ICommand
  {
    private String noCommand;
    private static NoCommand uniqueInstance;

    private NoCommand() 
    {
      noCommand = "No command set";
    }

    public static NoCommand getInstance()
    {
      if (uniqueInstance == null)
      {
        uniqueInstance= new NoCommand();
      }
      return uniqueInstance;
    }

    public void execute() { }
  }
}