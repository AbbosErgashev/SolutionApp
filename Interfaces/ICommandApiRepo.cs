using System.Collections.Generic;
using System.Threading.Tasks;
using Solution.Models;
using Solution.Datas.SavingDatasAsync;

namespace Solution.Interfaces
{
    public interface ICommandApiRepo : ISaveChangesAsync    //not use in project this file
    {
        Task<IEnumerable<Command>> GetAllCommands();

        Task<Command> GetCommandById(int id);

        Task CreateCommand(Command command);

        Task UpdateCommand(Command command);

        void DeleteCommand(Command command);
    }
}
