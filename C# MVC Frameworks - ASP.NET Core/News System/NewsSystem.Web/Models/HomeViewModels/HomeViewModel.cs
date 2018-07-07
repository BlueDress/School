using NewsSystem.Services.Models.Home;
using System.Collections.Generic;

namespace NewsSystem.Web.Models.HomeViewModels
{
    public class HomeViewModel
    {
          public IEnumerable<ArticleHomeListModel> TopThreeArticles { get; set; }
           
          public IEnumerable<CategoryHomeListModel> CategoriesWithTopThreeArticles { get; set; }
    }
}
