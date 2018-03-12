using System.ComponentModel.DataAnnotations;

namespace LearningSystem.Web.Models.ManageViewModels
{
    public class EditProfileViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(50, MinimumLength = 1)]
        public string Email { get; set; }

        public string StatusMessage { get; set; }
    }
}
