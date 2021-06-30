using System.Collections.Generic;
using Command1API.Models;

namespace Command1API.Data
{
    public interface ICommandAPIRepo
    {
        bool saveChanges();

        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}
