using System.ComponentModel.DataAnnotations;

namespace BookShop.Services.Models.Authors
{
    public class CreateAuthorModel
    {
        [Required]
        [MinLength(1)]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(25)]
        public string LastName { get; set; }
    }
}
