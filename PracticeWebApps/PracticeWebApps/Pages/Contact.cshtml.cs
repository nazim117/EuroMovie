using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeWebApps.DTOs;

namespace PracticeWebApps.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public ContactDTO ContactDTO { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
            {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Operation was not successful. Check input";

                return Page();
            }
            TempData["SuccessMessage"] = "Operation was successful.";
            return RedirectToAction("actionname", "controllername");

        }
    }
}
