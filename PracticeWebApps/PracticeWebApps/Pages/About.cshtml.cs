using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PracticeWebApps.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; private set; }

        public void OnGet()
        {
            Message = "Welcome to our about page";
        }
    }
}
