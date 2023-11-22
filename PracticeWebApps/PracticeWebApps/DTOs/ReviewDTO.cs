using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PracticeWebApps.DTOs
{
    public class ReviewDTO
    {
        [Required(ErrorMessage ="Rating is required")]
        public int Rating { get; set; }
        [Required(ErrorMessage ="Description is required")]
        public string Description { get; set; }
    }
}
