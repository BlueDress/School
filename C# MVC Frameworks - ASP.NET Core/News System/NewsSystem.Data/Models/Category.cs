using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NewsSystem.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Article> Articles { get; set; } = new List<Article>();
    }
}
