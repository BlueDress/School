using System.ComponentModel.DataAnnotations;

namespace LearningSystem.Services.Models.Articles
{
    public class PublishArticleModel
    {
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Title { get; set; }

        [Required]
        [StringLength(50000, MinimumLength = 1)]
        public string Content { get; set; }
    }
}
