using Geekend.Model.Requests.User;
using System.Threading.Tasks;

namespace Geekend.Service.Interfaces
{
    public interface IUserService
    {
        Task<bool> InsertUser(InsertUserDto insertUserDto);
    }
}
