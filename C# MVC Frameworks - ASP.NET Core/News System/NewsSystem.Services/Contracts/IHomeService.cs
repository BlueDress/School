using System.Collections.Generic;
using NewsSystem.Services.Models.Home;

namespace NewsSystem.Services.Contracts
{
    public interface IHomeService
    {
        IEnumerable<ArticleHomeListModel> GetTopThreeArticles();

        IEnumerable<CategoryHomeListModel> GetAllCategories();

        ArticleDetailsModel GetArticleById(int articleId);

        void LikeArticle(int articleId);

        void DislikeArticle(int articleId);
    }
}
