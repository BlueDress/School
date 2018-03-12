using System.Collections.Generic;
using LearningSystem.Data;
using LearningSystem.Services.Contracts;
using LearningSystem.Services.Models.Articles;
using System.Linq;
using System;
using LearningSystem.Data.Models;

namespace LearningSystem.Services.Implementations
{
    public class ArticleService : IArticleService
    {
        private readonly LearningSystemDbContext db;

        public ArticleService(LearningSystemDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<ListAllArticlesModel> GetAllArticles()
        {
            return this.db.Articles.Select(a => new ListAllArticlesModel
            {
                Id = a.Id,
                Title = a.Title,
                PublishDate = a.PublishDate,
                AuthorName = a.Author.Name
            });
        }

        public ReadArticleModel GetArticleById(int id)
        {
            return this.db.Articles.Where(a => a.Id == id).Select(a => new ReadArticleModel
            {
                Title = a.Title,
                Content = a.Content,
                PublishDate = a.PublishDate,
                AuthorName = a.Author.Name
            }).First();
        }

        public void PublishArticle(string title, string content, string authorId, DateTime articlePublishDate)
        {
            var article = new Article
            {
                Title = title,
                Content = content,
                PublishDate = articlePublishDate,
                AuthorId = authorId
            };

            this.db.Articles.Add(article);
            this.db.SaveChanges();
        }

        public bool ArticleExists(int id)
        {
            return this.db.Articles.Any(a => a.Id == id);
        }
    }
}
