using NewsSystem.Services.Models.Article;
using System.Collections.Generic;

namespace NewsSystem.Web.Models.ArticleViewModels
{
    public class ArticleListViewModel
    {
        public IEnumerable<ArticleListModel> Articles { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public ArticleSortTypes SortType { get; set; }
    }
}
