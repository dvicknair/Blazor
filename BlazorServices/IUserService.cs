using BlazorShare.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServices
{
    public interface IUserService
    {
        UserDTO Register(UserRegisterDTO user);
        UserDTO ValidateUser(UserRegisterDTO user);
    }
}
