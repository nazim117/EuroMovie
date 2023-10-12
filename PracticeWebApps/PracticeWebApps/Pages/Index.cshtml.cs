using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Managers;
using PracticeWebApps_DAL_Library;

namespace PracticeWebApps.Pages
{
    public class IndexModel : PageModel
	{	
		[BindProperty(SupportsGet =true)]
        public string Name { get; set; }

		public List<Movie> Movies = new List<Movie>();
		private ProductManager productManager;

        public IndexModel()
        {
			productManager = new ProductManager(new ProductDAL());
        }
        public void OnGet()
		{
			if (string.IsNullOrWhiteSpace(Name))
			{
				Name = "User";
			}
            string cookieValue = Request.Cookies["MyCookie"];

            // Use the cookie value as needed
            ViewData["CookieValue"] = cookieValue;

			foreach (Product movie in productManager.LoadObjects())
			{
				if (movie is Movie)
				{
					Movies.Add((Movie)movie);
				}
			}

        }
	}
}