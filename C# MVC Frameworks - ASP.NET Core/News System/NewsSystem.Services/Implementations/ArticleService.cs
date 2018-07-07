using System.Collections.Generic;
using NewsSystem.Data;
using NewsSystem.Services.Contracts;
using NewsSystem.Services.Models.Article;
using System.Linq;
using System;
using NewsSystem.Data.Models;

namespace NewsSystem.Services.Implementations
{
    public class ArticleService : IArticleService
    {
        private readonly NewsSystemDbContext db;

        public ArticleService(NewsSystemDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<ArticleListModel> GetAllArticles()
        {
            return this.db.Articles.Select(a => new ArticleListModel
            {
                Id = a.Id,
                Title = a.Title,
                Content = a.Content.Length <= 300 ? a.Content : a.Content.Substring(0, 300) + "...",
                PublishDate = a.PublishDate,
                Category = a.Category.Name,
                Likes = a.Likes
            }).OrderByDescending(a => a.PublishDate);
        }

        public string CreateArticle(string title, string content, string user, DateTime datePublished, string category)
        {
            Article article = new Article
            {
                Title = title,
                Content = content,
                AuthorId = user,
                PublishDate = datePublished,
                CategoryId = int.Parse(category)
            };

            this.db.Articles.Add(article);
            this.db.SaveChanges();

            return $"Article with title {title} created successfully.";
        }

        public ArticleEditModel GetArticleById(int articleId)
        {
            return this.db.Articles.Where(a => a.Id == articleId).Select(a => new ArticleEditModel
            {
                Id = a.Id,
                Title = a.Title,
                Content = a.Content,
                Category = a.Category.Name
            }).FirstOrDefault();
        }

        public string EditArticle(int articleId, string title, string content, string category)
        {
            Article article = this.db.Articles.FirstOrDefault(a => a.Id == articleId);

            article.Title = title;
            article.Content = content;
            article.CategoryId = int.Parse(category);

            this.db.SaveChanges();

            return $"Article edited successfully.";
        }

        public Article DeleteArticle(int articleId)
        {
            Article article = this.db.Articles.FirstOrDefault(a => a.Id == articleId);

            if (article != null)
            {
                this.db.Articles.Remove(article);
                this.db.SaveChanges();
            }

            return article;
        }
    }
}
