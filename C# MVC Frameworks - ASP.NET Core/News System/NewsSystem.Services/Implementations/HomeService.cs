using System.Collections.Generic;
using NewsSystem.Data;
using NewsSystem.Services.Contracts;
using NewsSystem.Services.Models.Home;
using System.Linq;
using NewsSystem.Data.Models;

namespace NewsSystem.Services.Implementations
{
    public class HomeService : IHomeService
    {
        private readonly NewsSystemDbContext db;

        public HomeService(NewsSystemDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<ArticleHomeListModel> GetTopThreeArticles()
        {
            return this.db.Articles.OrderByDescending(a => a.Likes).Take(3).Select(a => new ArticleHomeListModel
            {
                Id = a.Id,
                Title = a.Title,
                Content = a.Content.Length <= 500 ? a.Content : a.Content.Substring(0, 500) + "...",
                Likes = a.Likes
            });
        }

        public IEnumerable<CategoryHomeListModel> GetAllCategories()
        {
            return this.db.Categories.Select(c => new CategoryHomeListModel
            {
                Name = c.Name,
                Articles = c.Articles.OrderByDescending(a => a.Likes).Take(3),
            });
        }

        public ArticleDetailsModel GetArticleById(int articleId)
        {
            return this.db.Articles.Where(a => a.Id == articleId).Select(a => new ArticleDetailsModel
            {
                Id = a.Id,
                Title = a.Title,
                Content = a.Content,
                Category = a.Category.Name,
                DatePublished = a.PublishDate.ToShortDateString(),
                Author = a.Author.UserName,
                Likes = a.Likes,
                Dislikes = a.Dislikes
            }).FirstOrDefault();
        }

        public void LikeArticle(int articleId)
        {
            Article article = this.db.Articles.FirstOrDefault(a => a.Id == articleId);

            article.Likes++;

            this.db.SaveChanges();
        }

        public void DislikeArticle(int articleId)
        {
            Article article = this.db.Articles.FirstOrDefault(a => a.Id == articleId);

            article.Dislikes++;

            this.db.SaveChanges();
        }
    }
}
