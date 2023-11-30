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
		[BindProperty]
        public string searchQuery { get; set; }
		[BindProperty]
		public string sortingAlgo { get; set; }
		public List<Movie> Movies { get; private set; }
        public List<Serie> Series { get; private set; }
		private ProductManager productManager;

        public IndexModel()
        {
			Movies = new List<Movie>();
			Series = new List<Serie>();
			productManager = new ProductManager(new ProductDAL());
        }
        public void OnGet()
		{
            string cookieValue = Request.Cookies["MyCookie"];

            ViewData["CookieValue"] = cookieValue;

			foreach (Product movie in productManager.LoadObjects())
			{
				if (movie is Movie)
				{
					Movies.Add((Movie)movie);
				}
				else
				{
					Series.Add((Serie)movie);
				}
			}

        }
		public IActionResult OnPost()
		{
            return RedirectToPage("/Search", new { query = searchQuery, algorithm = sortingAlgo });
		}
	}
}