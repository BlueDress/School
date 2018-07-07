using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewsSystem.Services.Contracts;
using NewsSystem.Services.Models.Home;
using NewsSystem.Web.Models.HomeViewModels;
using System.Collections.Generic;

namespace NewsSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService homeService;

        public HomeController(IHomeService homeService)
        {
            this.homeService = homeService;
        }

        public IActionResult Index()
        {
            IEnumerable<ArticleHomeListModel> topThreeArticles = this.homeService.GetTopThreeArticles();

            IEnumerable<CategoryHomeListModel> categoriesWithTopThreeArticles = this.homeService.GetAllCategories();

            HomeViewModel model = new HomeViewModel
            {
                TopThreeArticles = topThreeArticles,
                CategoriesWithTopThreeArticles = categoriesWithTopThreeArticles
            };

            return View(model);
        }

        [Route("details/{articleId?}")]
        public IActionResult Details(int articleId)
        {
            ArticleDetailsModel article = this.homeService.GetArticleById(articleId);

            if (article == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(article);
        }

        [Authorize]
        [Route("like/{articleId?}")]
        public IActionResult Like(int articleId)
        {
            this.homeService.LikeArticle(articleId);

            return RedirectToAction(nameof(Details), new { articleId });
        }

        [Authorize]
        [Route("dislike/{articleId?}")]
        public IActionResult Dislike(int articleId)
        {
            this.homeService.DislikeArticle(articleId);

            return RedirectToAction(nameof(Details), new { articleId });
        }
    }
}
