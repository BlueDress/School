using System;
using System.ComponentModel.DataAnnotations;

namespace NewsSystem.Data.Models
{
    public class Article
    {
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(5000)]
        public string Content { get; set; }

        public DateTime PublishDate { get; set; }

        public long Likes { get; set; }
        public long Dislikes { get; set; }

        public string AuthorId { get; set; }
        public User Author { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
