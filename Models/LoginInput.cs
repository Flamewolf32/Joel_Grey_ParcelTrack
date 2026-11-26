using System.ComponentModel.DataAnnotations;

namespace ParcelTrack.Models
{
    public class LoginInput
    {
        [Required(ErrorMessage = "Give the email")]
        [EmailAddress(ErrorMessage = "That is not an email address")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Give the password")]
        public string Password { get; set; } = "";
    }
}
