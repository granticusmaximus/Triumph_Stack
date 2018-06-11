using System;
using AutoMapper;
using Business.Models;
using Business.DataAccess.DTO;

namespace Business.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
