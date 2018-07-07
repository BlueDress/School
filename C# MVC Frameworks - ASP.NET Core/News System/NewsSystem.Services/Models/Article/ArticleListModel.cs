using System;

namespace NewsSystem.Services.Models.Article
{
    public class ArticleListModel
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Content { get; set; }

        public DateTime PublishDate { get; set; }

        public long Likes { get; set; }

        public string Category { get; set; }
    }
}
