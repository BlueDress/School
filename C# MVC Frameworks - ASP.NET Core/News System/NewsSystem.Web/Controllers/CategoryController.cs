using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewsSystem.Data.Models;
using NewsSystem.Services.Contracts;
using NewsSystem.Services.Models.Category;
using NewsSystem.Web.Models;
using NewsSystem.Web.Models.CategoryViewModels;
using System.Collections.Generic;
using System.Linq;

namespace NewsSystem.Web.Controllers
{
    [Authorize]
    [Route("category")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        private const int pageSize = 5;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [Route("index/{sortType}/{categoryPage?}")]
        public IActionResult Index(string sortType, int categoryPage)
        {
            IList<CategoryNameModel> categoryNames = this.categoryService.GetAllCategories().ToList();
            bool sortAlphabetically = true;

            if (!sortType.ToLower().Equals("alphaup") && !sortType.ToLower().Equals("alphadown"))
            {
                return RedirectToAction(nameof(Index), new { sortType = "alphadown", categoryPage = 1 });
            }

            if (sortType.ToLower().Equals("alphaup"))
            {
                categoryNames = categoryNames.OrderByDescending(c => c.Name).ToList();
                sortAlphabetically = false;
            }

            PagingInfo pagingInfo = new PagingInfo
            {
                CurrentPage = categoryPage,
                ItemsPerPage = pageSize,
                TotalItems = categoryNames.Count()
            };

            CategoryListViewModel model = new CategoryListViewModel
            {
                CategoryNames = categoryNames.Skip((categoryPage - 1) * pageSize).Take(pageSize),
                PagingInfo = pagingInfo,
                SortAlphabetically = sortAlphabetically
            };

            return View(model);
        }

        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(CategoryNameModel category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }

            TempData["message"] = this.categoryService.CreateCategory(category.Name);

            return RedirectToAction(nameof(Index), new { sortType = "alphadown", categoryPage = 1 });
        }

        [Route("edit/{categoryId}")]
        public IActionResult Edit(int categoryId)
        {
            CategoryNameModel category = this.categoryService.GetCategoryById(categoryId);

            if (category == null)
            {
                return RedirectToAction(nameof(Index), new { sortType = "alphadown", categoryPage = 1 });
            }

            return View(category);
        }

        [HttpPost]
        [Route("edit/{categoryId}")]
        public IActionResult Edit(CategoryNameModel category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
                
            }

            TempData["message"] =  this.categoryService.EditCategory(category.Id, category.Name);

            return RedirectToAction(nameof(Index), new { sortType = "alphadown", categoryPage = 1 });
        }

        [Route("delete/{categoryId}")]
        public IActionResult Delete(int categoryId)
        {
            CategoryNameModel category = this.categoryService.GetCategoryById(categoryId);

            if (category == null)
            {
                return RedirectToAction(nameof(Index), new { sortType = "alphadown", categoryPage = 1 });
            }

            return View(category);
        }

        [HttpPost]
        [Route("delete/{categoryId}")]
        public IActionResult Delete(CategoryNameModel category)
        {
            Category deletedCategory = this.categoryService.DeleteCategory(category.Id);

            if (deletedCategory != null)
            {
                TempData["message"] = $"{deletedCategory.Name} was deleted";
            }

            return RedirectToAction(nameof(Index), new { sortType = "alphadown", categoryPage = 1 });
        }
    }
}
