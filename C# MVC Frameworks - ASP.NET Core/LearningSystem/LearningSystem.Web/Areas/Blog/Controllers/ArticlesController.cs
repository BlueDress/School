using LearningSystem.Data.Models;
using LearningSystem.Services.Contracts;
using LearningSystem.Services.Models.Articles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LearningSystem.Web.Areas.Blog.Controllers
{
    [Area("Blog")]
    public class ArticlesController : Controller
    {
        private readonly IArticleService articleService;
        private readonly UserManager<User> userManager;

        public ArticlesController(IArticleService articleService, UserManager<User> userManager)
        {
            this.articleService = articleService;
            this.userManager = userManager;
        }

        [AllowAnonymous]
        public IActionResult All()
        {
            var allArticles = this.articleService.GetAllArticles();

            return View(allArticles);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult All(string wordToSearch)
        {
            if (string.IsNullOrEmpty(wordToSearch) || string.IsNullOrWhiteSpace(wordToSearch))
            {
                var allArticles = this.articleService.GetAllArticles();

                return View(allArticles);
            }
            var allArticlesSearched = this.articleService.GetAllArticles().Where(a => a.Title.Contains(wordToSearch));

            return View(allArticlesSearched);
        }

        [Authorize]
        [Route("/blog/articles/read/{id}")]
        public IActionResult Read(int id)
        {
            if (!this.articleService.ArticleExists(id))
            {
                return RedirectToAction(nameof(All));
            }

            var article = this.articleService.GetArticleById(id);

            return View(article);
        }

        [Authorize(Roles = "BlogAuthor")]
        public IActionResult Publish()
        {
            return View(new PublishArticleModel { });
        }

        [Authorize(Roles = "BlogAuthor")]
        [HttpPost]
        public async Task<IActionResult> Publish(PublishArticleModel model)
        {
            var articlePublishDate = DateTime.Now;

            var user = await this.userManager.GetUserAsync(User);
            var authorId = user.Id;

            this.articleService.PublishArticle(model.Title, model.Content, authorId, articlePublishDate);

            return RedirectToAction(nameof(All));
        }
    }
}
