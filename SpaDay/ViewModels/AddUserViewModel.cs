using System;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 15 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Username must be between 6 and 20 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Compare("Password", ErrorMessage = "Passwords must match.")]
        public string VerifyPassword { get; set; }

        [EmailAddress]
        public string Email { get; set; }

    }
}
