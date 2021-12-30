using AutoMapper;
using Geekend.DB.Entities;
using Geekend.Model.Requests.User;
using Geekend.Model.Responses.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geekend.API.Utils
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //ReverseMap çift taraflı dönüşüm yapıyor.
            CreateMap<InsertUserDto, User>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<UpdateUserDto, User>().ReverseMap();
        }
    }
}
