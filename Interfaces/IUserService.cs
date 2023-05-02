using System.Threading.Tasks;
using Solution.Models.User;
using Solution.Models;
using System.Collections.Generic;

namespace Solution.Interfaces
{
    public interface IUserService
    {
        Task<LoginTokenModel> Login(UserLoginModel userLoginModel);
        Task<UserModel> Register(UserModel userModel);
        Task<UserModel> Activate(ActiveUserModel activeUserModel);

        Task AccessUser(List<UserAccessModel> controlUserModels);

        Task<List<UserModel>> GetAllAsync();
        Task<UserModel> GetUserByIdAsync(int id);
        Task<UserModel> AddAsync(UserModel user);

        Task<UserInfoModel> UserInfo(int id);
        Task UpdateAsync(UserModel user);
        Task<UserModel> DeleteAsync(int id);

        Task<List<string>> GetAllPermissions(int id);
    }
}