using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data 
{
  public class MockCommanderRepo : ICommanderRepo
  {
    public IEnumerable<Command> GetAllCommands()
    {
      var commands = new List<Command>
      {
        new Command{ Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle and pan"},
        new Command{ Id=1, HowTo="Chop a carrot", Line="Get knife", Platform="Knife and board"},
        new Command{ Id=2, HowTo="Make coffee", Line="Place coffee in cup", Platform="Press and grounds"}
      };

      return commands;
    }

    public Command GetCommandById(int id)
    {
      return new Command{ Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle and pan"};
    }
  }
}