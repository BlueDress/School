using CameraBazaar.Services.Contracts;
using CameraBazaar.Services.Models;
using CameraBazaar.Web.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CameraBazaar.Web.Controllers
{
    [Route("users")]
    public class UsersController : Controller
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [Authorize]
        [Route("details/{username}")]
        public IActionResult Details(string username)
        {
            var isCurrentUser = false;

            if (this.User.FindFirstValue(ClaimTypes.Name).ToLower().Equals(username.ToLower()))
            {
                isCurrentUser = true;
            }

            var user = this.userService.GetUserDetails(username);

            return View(new UserDetailsViewModel
            {
                User = user,
                IsCurrentUser = isCurrentUser
            });
        }

        [Authorize]
        [Route("edit/{username}")]
        public IActionResult Edit(string username)
        {
            if (!this.User.FindFirstValue(ClaimTypes.Name).ToLower().Equals(username.ToLower()))
            {
                return Redirect($"/users/details/{username}");
            }

            var user = this.userService.GetUserForEdit(username);

            return View(user);
        }

        [Authorize]
        [HttpPost]
        [Route("edit/{username}")]
        public IActionResult Edit(EditUserModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            this.userService.EditUser(model.Username, model.Email, model.NewPassword, model.Phone);

            return Redirect($"/users/details/{model.Username}");
        }
    }
}
