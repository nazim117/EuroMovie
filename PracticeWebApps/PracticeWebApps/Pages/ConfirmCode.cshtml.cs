using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeWebApps.DTOs;
using PracticeWebApps_LogicLibrary.Managers;

namespace PracticeWebApps.Pages
{
    public class ConfirmCodeModel : PageModel
    {
        [BindProperty]
        public int EnteredCode { get; set; }
        [BindProperty(SupportsGet =true)]
        public int Code { get; set; }
        public string ErrorMessage { get; set; }
        public string PageTitle { get; set; }

        private readonly ILogger<ConfirmCodeModel> _logger;
        public ConfirmCodeModel(ILogger<ConfirmCodeModel> logger)
        {
            _logger = logger;
            PageTitle = "Confirm Code";
            ErrorMessage = string.Empty;
            
        }
        public void OnGet()
        {
            Code = (int)TempData["GeneratedCode"];
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (EnteredCode != Code)
            {
                ErrorMessage = "Invalid code";
                return Page();
            }

            return RedirectToPage("/UpdatePassword");
        }
    }
}  
