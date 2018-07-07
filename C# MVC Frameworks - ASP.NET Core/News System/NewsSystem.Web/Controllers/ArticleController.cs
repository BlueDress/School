using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NewsSystem.Data.Models;
using NewsSystem.Services.Contracts;
using NewsSystem.Services.Models.Article;
using NewsSystem.Services.Models.Category;
using NewsSystem.Web.Models;
using NewsSystem.Web.Models.ArticleViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NewsSystem.Web.Controllers
{
    [Authorize]
    [Route("article")]
    public class ArticleController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly IArticleService articleService;
        private readonly ICategoryService categoryService;
        private const int pageSize = 5;

        public ArticleController(IArticleService articleService, ICategoryService categoryService, UserManager<User> userManager)
        {
            this.articleService = articleService;
            this.categoryService = categoryService;
            this.userManager = userManager;
        }

        [Route("index/{sortType}/{articlePage?}")]
        public IActionResult Index(string sortType, int articlePage)
        {
            IList<ArticleListModel> articles = this.articleService.GetAllArticles().ToList();
            ArticleSortTypes type = ArticleSortTypes.ByDate;

            if (sortType.ToLower().Equals(ArticleSortTypes.ByTitle.ToString().ToLower()))
            {
                articles = articles.OrderBy(a => a.Title).ToList();
                type = ArticleSortTypes.ByTitle;
            }
            else if (sortType.ToLower().Equals(ArticleSortTypes.ByCategory.ToString().ToLower()))
            {
                articles = articles.OrderBy(a => a.Category).ToList();
                type = ArticleSortTypes.ByCategory;
            }
            else if (sortType.ToLower().Equals(ArticleSortTypes.ByLikes.ToString().ToLower()))
            {
                articles = articles.OrderByDescending(a => a.Likes).ToList();
                type = ArticleSortTypes.ByLikes;
            }
            else if (sortType.ToLower().Equals(ArticleSortTypes.ByDate.ToString().ToLower()))
            {
            }
            else
            {
                return RedirectToAction(nameof(Index), new { sortType = "bydate", articlePage = 1 });
            }

            PagingInfo pagingInfo = new PagingInfo
            {
                CurrentPage = articlePage,
                ItemsPerPage = pageSize,
                TotalItems = articles.Count()
            };

            ArticleListViewModel model = new ArticleListViewModel
            {
                Articles = articles.Skip((articlePage - 1) * pageSize).Take(pageSize),
                PagingInfo = pagingInfo,
                SortType = type
            };

            return View(model);
        }

        [Route("create")]
        public IActionResult Create()
        {
            IEnumerable<SelectListItem> categoryNames = GetCategoryNames();

            return View(new ArticleCreateViewModel { Categories = categoryNames });
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(ArticleCreateViewModel article)
        {
            if (!ModelState.IsValid)
            {
                article.Categories = GetCategoryNames();

                return View(article);
            }

            string user = userManager.GetUserId(HttpContext.User);
            DateTime datePublished = DateTime.UtcNow;

            TempData["message"] = this.articleService.CreateArticle(article.Title, article.Content, user, datePublished, article.Category);

            return RedirectToAction(nameof(Index), new { sortType = "bydate", articlePage = 1 });
        }

        [Route("edit/{articleId}")]
        public IActionResult Edit(int articleId)
        {
            ArticleEditModel article = this.articleService.GetArticleById(articleId);

            if (article == null)
            {
                return RedirectToAction(nameof(Index), new { sortType = "bydate", articlePage = 1 });
            }

            ArticleEditViewModel model = new ArticleEditViewModel
            {
                Id = article.Id,
                Title = article.Title,
                Content = article.Content,
                Category = article.Category,
                Categories = GetCategoryNames()
            };
            
            return View(model);
        }

        [HttpPost]
        [Route("edit/{articleId}")]
        public IActionResult Edit(ArticleEditViewModel article)
        {
            if (!ModelState.IsValid)
            {
                article.Categories = GetCategoryNames();

                return View(article);
            }

            TempData["message"] = this.articleService.EditArticle(article.Id, article.Title, article.Content, article.Category);

            return RedirectToAction(nameof(Index), new { sortType = "bydate", articlePage = 1 });
        }

        [Route("delete/{articleId}")]
        public IActionResult Delete(int articleId)
        {
            ArticleEditModel article = this.articleService.GetArticleById(articleId);

            if (article == null)
            {
                return RedirectToAction(nameof(Index), new { sortType = "bydate", articlePage = 1 });
            }

            return View(article);
        }

        [HttpPost]
        [Route("delete/{articleId}")]
        public IActionResult Delete(ArticleEditModel article)
        {
            Article deletedArticle = this.articleService.DeleteArticle(article.Id);

            if (deletedArticle != null)
            {
                TempData["message"] = $"{deletedArticle.Title} was deleted";
            }

            return RedirectToAction(nameof(Index), new { sortType = "bydate", articlePage = 1 });
        }

        private IEnumerable<SelectListItem> GetCategoryNames()
        {
            IList<CategoryNameModel> categories = this.categoryService.GetAllCategories().ToList();

            IEnumerable<SelectListItem> categoryNames = categories.Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString()
            });

            return categoryNames;
        }
    }
}
