using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LearningSystem.Web.Models;
using LearningSystem.Services.Contracts;
using AutoMapper.QueryableExtensions;
using LearningSystem.Services.Models.Courses;
using System.Linq;

namespace LearningSystem.Data.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICoursesService homeService;

        public HomeController(ICoursesService homeService)
        {
            this.homeService = homeService;
        }

        public IActionResult Index()
        {
            var allCourses = this.homeService.GetAllCourses().ProjectTo<ListAllCoursesModel>();

            return View(allCourses);
        }

        [HttpPost]
        public IActionResult Index(string wordToSearch)
        {
            if (string.IsNullOrEmpty(wordToSearch) || string.IsNullOrWhiteSpace(wordToSearch))
            {
                var allCourses = this.homeService.GetAllCourses().ProjectTo<ListAllCoursesModel>();

                return View(allCourses);
            }

            var allCoursesSearched = this.homeService.GetAllCourses().ProjectTo<ListAllCoursesModel>().Where(c => c.Name.Contains(wordToSearch));

            return View(allCoursesSearched);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
