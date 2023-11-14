using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PracticeWebApps.Pages
{
    [Authorize]
    public class AddReviewModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
