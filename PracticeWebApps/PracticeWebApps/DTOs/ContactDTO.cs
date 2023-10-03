using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PracticeWebApps.DTOs
{
    public class ContactDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
    }
}
