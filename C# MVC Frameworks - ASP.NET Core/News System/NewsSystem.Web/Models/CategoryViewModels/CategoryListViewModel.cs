using NewsSystem.Services.Models.Category;
using System.Collections.Generic;

namespace NewsSystem.Web.Models.CategoryViewModels
{
    public class CategoryListViewModel
    {
        public IEnumerable<CategoryNameModel> CategoryNames { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public bool SortAlphabetically { get; set; }
    }
}
