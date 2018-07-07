namespace NewsSystem.Services.Models.Home
{
    public class ArticleDetailsModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }

        public string DatePublished { get; set; }

        public long Likes { get; set; }

        public long Dislikes { get; set; }
    }
}
