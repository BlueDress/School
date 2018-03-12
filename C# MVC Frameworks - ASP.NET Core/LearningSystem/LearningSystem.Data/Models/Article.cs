using System;
using System.ComponentModel.DataAnnotations;

namespace LearningSystem.Data.Models
{
    public class Article
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Title { get; set; }

        [Required]
        [StringLength(50000, MinimumLength = 1)]
        public string Content { get; set; }

        public DateTime PublishDate { get; set; }

        public string AuthorId { get; set; }
        public User Author { get; set; }
    }
}
