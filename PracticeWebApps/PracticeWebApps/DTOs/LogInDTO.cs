using System.ComponentModel.DataAnnotations;

namespace PracticeWebApps.DTOs
{
    public class LogInDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
