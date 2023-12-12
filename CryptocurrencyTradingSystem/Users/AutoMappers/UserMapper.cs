using AutoMapper;
using CryptocurrencyTradingSystem.Core.EF.Entities;
using Users.DTOs;
using Users.Models;

namespace Users.AutoMappers
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<LoginModel, LoginDTO>();
            CreateMap<RegisterModel, RegisterDTO>();
            CreateMap<RegisterModel, LoginDTO>();
            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<RegisterDTO, User>().ReverseMap();
        }
    }
}
