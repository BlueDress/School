using System.ComponentModel.DataAnnotations;

namespace NewsSystem.Services.Models.Category
{
    public class CategoryNameModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Name { get; set; }
    }
}
