using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Data.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(25)]
        public string LastName { get; set; }

        public IEnumerable<Book> Books { get; set; } = new List<Book>();
    }
}
