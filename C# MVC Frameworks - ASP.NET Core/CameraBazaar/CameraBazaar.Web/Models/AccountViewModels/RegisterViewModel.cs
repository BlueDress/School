﻿using System.ComponentModel.DataAnnotations;

namespace CameraBazaar.Web.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Username")]
        [RegularExpression("[A-Za-z]+", ErrorMessage = "Username must be composed only by letters.")]
        [MinLength(4, ErrorMessage = "Username must be atleast four letters.")]
        [MaxLength(20, ErrorMessage = "Username must not be longer than twenty letters.")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [RegularExpression(@"\+\d{10,12}", ErrorMessage = "Phone number must start with '+' sign and contain between ten and twelve digits.")]
        public string Phone { get; set; }
    }
}
