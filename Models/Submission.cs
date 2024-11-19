using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMvcApp.Models
{
    public class Submission
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set; } = string.Empty;

        public int? Age { get; set; }

        public string? ContactNumber { get; set; }
    }
}
