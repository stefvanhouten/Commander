using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo //Implement, not inherit! This is because the MockCommanderRepo is an interface
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water",  PlatForm = "Kettle & Pan" },
                new Command { Id = 1, HowTo = "Cut bread", Line = "Get a knife", PlatForm = "Knife & chopping board" },
                new Command { Id = 2, HowTo = "Make a cup of tea", Line = "Place teabag in cup",  PlatForm = "Kettle & cup" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", PlatForm = "Kettle & Pan" };
        }
        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

    }
}
