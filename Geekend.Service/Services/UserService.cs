using AutoMapper;
using Geekend.DB.Entities;
using Geekend.DB.Entities.GeekendDbContext;
using Geekend.Model.Requests.User;
using Geekend.Service.Interfaces;
using System.Threading.Tasks;

namespace Geekend.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;

        public UserService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<bool> InsertUser(InsertUserDto insertUserDto)
        {
            var user = _mapper.Map<User>(insertUserDto);
            bool response = false;
            using (var dbContext = new GeekendContext())
            {
                var result = await dbContext.User.AddAsync(user);
                await dbContext.SaveChangesAsync();
                if (result.Entity.Id > 0)
                    response = true;
            }
            return response;
        }
    }
}
