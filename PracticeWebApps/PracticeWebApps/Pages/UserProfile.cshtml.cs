using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeWebApps.DTOs;
using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain;
using PracticeWebApps_LogicLibrary.Managers;
using System.IO;
using System.Reflection.Emit;

namespace PracticeWebApps.Pages
{
    public class UserProfileModel : PageModel
    {
        [BindProperty]
        public string ErrorMessage { get; set; }
        public string PageTitle { get; set; }

        private readonly ILogger<UserProfileModel> _logger;
        public UserProfileModel(ILogger<UserProfileModel> logger)
        {
            _logger = logger;
            PageTitle = "User Profile";
            ErrorMessage = string.Empty;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
