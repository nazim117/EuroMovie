using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeWebApps_Domain.Models.Products;

namespace PracticeWebApps.Pages
{
    public class IndexModel : PageModel
	{	
		[BindProperty(SupportsGet =true)]
        public string Name { get; set; }

		[BindProperty]
		public List<Movie> Movies { get; set; }

        public void OnGet()
		{
			if (string.IsNullOrWhiteSpace(Name))
			{
				Name = "User";
			}
            string cookieValue = Request.Cookies["MyCookie"];

            // Use the cookie value as needed
            ViewData["CookieValue"] = cookieValue;



        }

		public void OnPost() 
		{
		}
	}
}