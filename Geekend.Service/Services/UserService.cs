using AutoMapper;
using Geekend.DB.Entities;
using Geekend.DB.Entities.GeekendDbContext;
using Geekend.Model.Requests.User;
using Geekend.Model.Responses.User;
using Geekend.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;
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

        //List all users
        public async Task<List<UserDto>> GetAllUsers()
        {
            var user = new List<UserDto>();
            bool response = false;
            using (var dbContext = new GeekendContext())
            {
                var result = dbContext.User.OrderBy(x => x.Id);
                user = _mapper.Map<List<UserDto>>(result);
            }
            return user;
        }

        //List user by ID
        public async Task<List<UserDto>> GetUserById(int getUserById)
        {
            var user = new List<UserDto>();
            bool response = false;
            using (var dbContext = new GeekendContext())
            {
                var result = dbContext.User.Where(x => x.Id == getUserById);
                user = _mapper.Map<List<UserDto>>(result);
            }
            return user;
        }

        //Insert a user
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


        // TODO Update is not working correctly, fix it!
        //Update a user
        public async Task<bool> UpdateUser(UpdateUserDto updateUserDto)
        {
            var user = _mapper.Map<User>(updateUserDto);
            bool response = false;
            using (var dbContext = new GeekendContext())
            {
                var result = dbContext.User.Update(user);
                //result.Entity.UpdateDate = System.DateTime.Now;
                dbContext.SaveChanges();
                if (result.Entity.Id > 0)
                    response = true;
            }
            return response;
        }
    }
}
