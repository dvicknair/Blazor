using BlazorServices;
using BlazorShare.DTOs;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public partial class Users
    {
        public List<UserDTO> UserList { get; set; } = new List<UserDTO>();
        [Inject] protected IUserService _userService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            UserList = (await _userService.GetUsers()).ToList();
        }
        public async void OnUserAdded()
        {
            UserList = (await _userService.GetUsers()).ToList();
        }
    }
}
