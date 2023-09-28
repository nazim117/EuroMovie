using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PracticeWebApps.Pages
{
    public class LogOutModel : PageModel
    {
        public string PageTitle { get; set; }
        public LogOutModel()
        {
            PageTitle = "Log Out";
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            HttpContext.SignOutAsync().Wait(); // Wait for the task to complete
            //HttpContext.Session.Clear();
            return RedirectToPage("/Index"); // Redirect after logout
        }
    }
}
