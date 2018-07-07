using System;
using System.Collections.Generic;
using NewsSystem.Data.Models;
using NewsSystem.Services.Models.Article;

namespace NewsSystem.Services.Contracts
{
    public interface IArticleService
    {
        IEnumerable<ArticleListModel> GetAllArticles();

        string CreateArticle(string title, string content, string user, DateTime datePublished, string category);

        ArticleEditModel GetArticleById(int articleId);

        string EditArticle(int articleId, string title, string content, string category);

        Article DeleteArticle(int articleId);
    }
}
