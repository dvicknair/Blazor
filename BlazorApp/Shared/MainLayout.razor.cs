using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace BlazorApp.Shared
{
    public partial class MainLayout
    {
        //[Inject]
        //private IHttpContextAccessor _IHttpContextAccessor { get; set; }
        //[Inject]
        //private AuthenticationStateProvider _AuthenticationStateProvider { get; set; }

        //protected override async Task OnInitializedAsync()
        //{
        //    var authState = await _AuthenticationStateProvider.GetAuthenticationStateAsync();
        //    var user = authState.User;

        //    if (!user.Identity.IsAuthenticated)
        //    {
        //        var claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name, "John Doe")
        //        };

        //        var claimsIdentity = new ClaimsIdentity(
        //            claims,
        //            CookieAuthenticationDefaults.AuthenticationScheme);

        //        await HttpContext.SignInAsync(
        //            CookieAuthenticationDefaults.AuthenticationScheme,
        //            new ClaimsPrincipal(claimsIdentity));
        //        //await ProtectedSessionStore.SetAsync("userName", user.Identity.Name);
        //    }
        //}
    }
}
