using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Data.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(5000)]
        public string Description { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue)]
        public int Copies { get; set; }

        public int AgeRestriction { get; set; }

        public int? Edition { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public IEnumerable<CategoryBook> Categories { get; set; } = new List<CategoryBook>();
    }
}
