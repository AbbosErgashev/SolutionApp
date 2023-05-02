using System.Collections.Generic;
using System.Threading.Tasks;
using Solution.Datas.SavingDatasAsync;
using Solution.Models;

namespace Solution.Interfaces
{
    public interface IUserApiRepo : ISaveChangesAsync
    {
        Task<IEnumerable<UserModel>> GetAllUsers();

        Task<UserModel> GetUserById(int id);

        Task CreateUser(UserModel user);

        Task UpdateUser(UserModel user);

        void DeleteUser(UserModel user);
    }
}