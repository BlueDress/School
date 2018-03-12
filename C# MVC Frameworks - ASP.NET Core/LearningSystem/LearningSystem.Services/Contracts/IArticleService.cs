using LearningSystem.Services.Models.Articles;
using System.Collections.Generic;
using System;

namespace LearningSystem.Services.Contracts
{
    public interface IArticleService
    {
        IEnumerable<ListAllArticlesModel> GetAllArticles();

        ReadArticleModel GetArticleById(int id);

        void PublishArticle(string title, string content, string authorId, DateTime articlePublishDate);

        bool ArticleExists(int id);
    }
}
