using System;

namespace LearningSystem.Services.Models.Articles
{
    public class ListAllArticlesModel
    {
        public int Id { get; set; }
        
        public string Title { get; set; }

        public DateTime PublishDate { get; set; }

        public string AuthorName { get; set; }
    }
}
