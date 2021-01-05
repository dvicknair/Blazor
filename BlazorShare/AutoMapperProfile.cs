using AutoMapper;
using BlazorData.Models;
using BlazorShare.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorShare
{
    class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserRegisterDTO, User>();
            CreateMap<User, UserDTO>();
        }
    }
}
