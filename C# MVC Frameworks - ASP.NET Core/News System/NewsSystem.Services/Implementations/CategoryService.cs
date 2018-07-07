using System.Collections.Generic;
using NewsSystem.Data;
using NewsSystem.Services.Contracts;
using System.Linq;
using NewsSystem.Services.Models.Category;
using NewsSystem.Data.Models;

namespace NewsSystem.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly NewsSystemDbContext db;

        public CategoryService(NewsSystemDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<CategoryNameModel> GetAllCategories()
        {
            return this.db.Categories.Select(c => new CategoryNameModel
            {
                Id = c.Id,
                Name = c.Name
            }).OrderBy(c => c.Name);
        }

        public string CreateCategory(string name)
        {
            if (this.db.Categories.Any(c => c.Name.ToLower().Equals(name.ToLower())))
            {
                return $"Category {name} already exists.";
            }

            Category category = new Category
            {
                Name = name
            };

            this.db.Categories.Add(category);
            this.db.SaveChanges();

            return $"Category {name} created.";
        }

        public CategoryNameModel GetCategoryById(int categoryId)
        {
            return this.db.Categories
                .Where(c => c.Id == categoryId)
                .Select(c => new CategoryNameModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .FirstOrDefault();
        }

        public string EditCategory(int categoryId, string name)
        {
            if (this.db.Categories.Any(c => c.Name.ToLower().Equals(name.ToLower())))
            {
                return $"Category {name} already exists.";
            }

            Category category = this.db.Categories.FirstOrDefault(c => c.Id == categoryId);

            category.Name = name;

            this.db.SaveChanges();

            return $"Category {name} edited.";
        }

        public Category DeleteCategory(int categoryId)
        {
            Category category = this.db.Categories.FirstOrDefault(c => c.Id == categoryId);

            if (category != null)
            {
                IQueryable<Article> articlesToRemove = this.db.Articles.Where(a => a.CategoryId == categoryId);
                this.db.RemoveRange(articlesToRemove);
                this.db.Categories.Remove(category);
                db.SaveChanges();
            }

            return category;
        }
    }
}
