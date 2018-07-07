namespace NewsSystem.Services.Models.Home
{
    using System.Collections.Generic;
    using NewsSystem.Data.Models;

    public class CategoryHomeListModel
    {
        public string Name { get; set; }

        public IEnumerable<Article> Articles { get; set; }
    }
}
