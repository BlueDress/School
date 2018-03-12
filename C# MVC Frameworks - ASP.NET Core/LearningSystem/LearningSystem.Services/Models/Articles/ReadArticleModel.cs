using System;

namespace LearningSystem.Services.Models.Articles
{
    public class ReadArticleModel
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime PublishDate { get; set; }

        public string AuthorName { get; set; }
    }
}
