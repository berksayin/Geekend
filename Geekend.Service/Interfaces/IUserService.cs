using Geekend.Model.Requests.User;
using Geekend.Model.Responses.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Geekend.Service.Interfaces
{
    public interface IUserService
    {
        //List all users
        Task<List<UserDto>> GetAllUsers();
        //List user by ID
        Task<List<UserDto>> GetUserById(int getUserById);
        //Insert a user
        Task<bool> InsertUser(InsertUserDto insertUserDto);
        //Update a user
        Task<bool> UpdateUser(UpdateUserDto updateUserDto);
    }
}
