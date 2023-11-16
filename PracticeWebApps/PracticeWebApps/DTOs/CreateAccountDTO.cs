using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PracticeWebApps.DTOs
{
    public class CreateAccountDTO
    {
        [Required,
            StringLength
            (
            maximumLength:15, 
            MinimumLength=3, 
            ErrorMessage = "Name should be longer than 2 characters"
            )
        ]
        [RegularExpression(@"^[A-Za-z]+(?: [A-Za-z]+)?$", 
            ErrorMessage ="Invalid Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email required")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-]+)(\.[a-zA-Z]{2,5}){1,2}$",
            ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number required")]
        [RegularExpression(@"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$",
            ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Minimum eight characters, at least one letter and one number")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$",
            ErrorMessage = "Minimum eight characters, at least one letter and one number")]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Passwords do not match")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
