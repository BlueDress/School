using LearningSystem.Data.Models;
using LearningSystem.Services.Contracts;
using LearningSystem.Services.Models.Courses;
using LearningSystem.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace LearningSystem.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class UsersController : Controller
    {
        private readonly ICoursesService courseService;
        private readonly IUserService userService;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UsersController(ICoursesService courseService, IUserService userService, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.courseService = courseService;
            this.userService = userService;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public IActionResult CreateCourse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCourse(CreateCourseModel model)
        {
            this.courseService.CreateCourse(model.Name, model.Description, model.StartDate, model.EndDate, model.TrainerId);

            return Redirect("/");
        }

        public IActionResult AllUsers()
        {
            var allUsers = this.userService.GetAllUsers();

            var roles = this.roleManager.Roles.Select(r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Name
            });

            var model = new AddUserToRoleModel
            {
                Roles = roles,
                Users = allUsers
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult AllUsers(string wordToSearch)
        {
            if (string.IsNullOrEmpty(wordToSearch) || string.IsNullOrWhiteSpace(wordToSearch))
            {
                var allUsers = this.userService.GetAllUsers();

                var roles = this.roleManager.Roles.Select(r => new SelectListItem
                {
                    Text = r.Name,
                    Value = r.Name
                });

                var model = new AddUserToRoleModel
                {
                    Roles = roles,
                    Users = allUsers
                };

                return View(model);
            }

            var allUsersSearched = this.userService.GetAllUsers().Where(u => u.Name.Contains(wordToSearch));

            var rolesSearched = this.roleManager.Roles.Select(r => new SelectListItem
            {
                Text = r.Name,
                Value = r.Name
            });

            var modelSearched = new AddUserToRoleModel
            {
                Roles = rolesSearched,
                Users = allUsersSearched
            };

            return View(modelSearched);
        }

        [HttpPost]
        public async Task<IActionResult> AddToRole(string role, string userId)
        {
            var user = await this.userManager.FindByIdAsync(userId);

            await this.userManager.AddToRoleAsync(user, role);

            return RedirectToAction(nameof(AllUsers));
        }
    }
}
