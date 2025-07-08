using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class UserModel
    {
        [Required]
        public string Name { get; set; } = "";

        [Required, EmailAddress]
        public string Email { get; set; } = "";
    }
}
