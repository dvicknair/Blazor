using BlazorShare.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServices
{
    public interface IUserService
    {
        UserDTO Register(UserRegisterDTO user);
        UserDTO ValidateUser(UserRegisterDTO user);
        Task<IEnumerable<UserDTO>> GetUsers();
    }
}
