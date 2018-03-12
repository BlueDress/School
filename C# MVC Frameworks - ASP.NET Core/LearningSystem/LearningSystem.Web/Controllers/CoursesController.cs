using LearningSystem.Data.Models;
using LearningSystem.Services.Contracts;
using LearningSystem.Services.Models.Courses;
using LearningSystem.Web.Models.Courses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LearningSystem.Web.Controllers
{
    [Route("courses")]
    public class CoursesController : Controller
    {
        private readonly ICoursesService coursesService;
        private readonly UserManager<User> userManager;

        public CoursesController(ICoursesService coursesService, UserManager<User> userManager)
        {
            this.coursesService = coursesService;
            this.userManager = userManager;
        }

        [Route("view/{id}")]
        public IActionResult Preview(int id)
        {
            if (!this.coursesService.CourseExists(id))
            {
                return Redirect("/");
            }

            var course = this.coursesService.GetCourseById(id);

            return View(course);
        }
        
        [HttpPost]
        [Route("view/{id}")]
        public IActionResult Preview(ViewCourseModel model)
        {
            return RedirectToAction("signuptocourse", "manage", model);
        }

        [Authorize(Roles = "Trainer")]
        [Route("my")]
        public IActionResult TrainersCourses()
        {
            var id = this.userManager.GetUserId(HttpContext.User);

            var model = this.coursesService.GetAllCoursesByTrainerId(id);

            return View(model);
        }

        [Authorize(Roles = "Trainer")]
        [Route("trainerview/{id}")]
        public IActionResult TrainerView(int id)
        {
            if (!this.coursesService.CourseExists(id))
            {
                return Redirect("/");
            }

            var course = this.coursesService.GetCourseById(id);

            return View(course);
        }

        [Authorize(Roles = "Trainer")]
        [Route("viewstudents/{id}")]
        public IActionResult ViewStudents(int id)
        {
            if (!this.coursesService.CourseExists(id))
            {
                return Redirect("/");
            }

            var studentsInCourse = this.coursesService.GetStudentsInCourseById(id);
            var endDate = this.coursesService.GetCourseById(id).EndDate;

            var model = new TrainerViewStudentsModel
            {
                Students = studentsInCourse,
                EndDate = endDate
            };

            return View(model);
        }
    }
}
