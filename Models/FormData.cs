using System.ComponentModel.DataAnnotations;

namespace ValidatingFormSubmission.Models
{
    public class FormData
    {
        [Required]
        [MinLength(4)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(4)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The Age field is required")]
        [Range(0,120, ErrorMessage = "Please enter a value bigger than 0")]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        [RegularExpression("^[a-zA-Z0-9.+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]+$")]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }
    }
}