using BlazorServices;
using BlazorShare.DTOs;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public partial class Register
    {
        [Inject] protected IUserService _userService { get; set; }
        public UserRegisterDTO UserRegister = new();
        private void HandleValidSubmit()
        {
            _userService.Register(UserRegister);
        }
    }
}
