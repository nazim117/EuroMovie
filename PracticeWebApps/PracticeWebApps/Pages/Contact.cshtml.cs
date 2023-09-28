using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeWebApps_Domain.Models.Users;

namespace PracticeWebApps.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public UserModel UserModel { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            TempData["Success"] = "Added Successfully!";
            return RedirectToAction("actionname", "controllername");

        }
    }
}
