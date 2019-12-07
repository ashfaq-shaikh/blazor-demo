using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zobi.Domain.Models;

namespace BlazorApp_Demo_ZobiWebSolutions.Pages
{
    public class LoginModel : PageModel
    {
        public List<UserModel> lstUserModel { get; set; }
        public LoginModel()
        {
            ///Static user data
            this.lstUserModel = new List<UserModel> {
                    new UserModel { Id = 1, Username = "User1", Email = "user1@gmail.com", Password = "123456" },
                    new UserModel { Id = 2, Username = "User2", Email = "user2@gmail.com", Password = "123456" },
                    new UserModel { Id = 3, Username = "User3", Email = "user3@gmail.com", Password = "123456" },
                    new UserModel { Id = 4, Username = "User4", Email = "user4@gmail.com", Password = "123456" },
                    new UserModel { Id = 5, Username = "User5", Email = "user5@gmail.com", Password = "123456" },
                    new UserModel { Id = 6, Username = "User6", Email = "user6@gmail.com", Password = "123456" }
            };
        }

        public string ReturnUrl { get; set; }

        /// <summary>
        /// Login get event. Pass username and password in parameter.
        /// </summary>
        /// <param name="paramUsername">email</param>
        /// <param name="paramPassword">password</param>
        /// <returns></returns>
        public async Task<IActionResult> OnGetAsync(string paramUsername, string paramPassword)
        {
            string returnUrl = Url.Content("~/");

            // Clear the existing external cookie
            await HttpContext
                .SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);

            if (lstUserModel.Any(x => x.Email == paramUsername && x.Password == paramPassword))
            {

                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, paramUsername),
                new Claim(ClaimTypes.Role, "Administrator"),
            };
                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true,
                    RedirectUri = this.Request.Host.Value
                };
                try
                {
                    await HttpContext.SignInAsync(
                  CookieAuthenticationDefaults.AuthenticationScheme,
                  new ClaimsPrincipal(claimsIdentity),
                  authProperties);

                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                }
                return LocalRedirect(returnUrl);
            }
            else
            {
                return LocalRedirect(returnUrl + "loginError?name=Login failed.");
            }
        }
    }
}
