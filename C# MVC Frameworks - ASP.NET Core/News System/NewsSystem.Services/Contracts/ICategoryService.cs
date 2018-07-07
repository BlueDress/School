using NewsSystem.Services.Models.Category;
using System.Collections.Generic;
using NewsSystem.Data.Models;

namespace NewsSystem.Services.Contracts
{
    public interface ICategoryService
    {
        IEnumerable<CategoryNameModel> GetAllCategories();

        string CreateCategory(string name);

        CategoryNameModel GetCategoryById(int categoryId);

        string EditCategory(int categoryId, string name);

        Category DeleteCategory(int categoryId);
    }
}
