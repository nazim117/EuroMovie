using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Managers;

namespace PracticeWebApps.Pages
{
    public class SearchModel : PageModel
    {
        public HashSet<Product> SearchResults { get; private set; }
        private ProductManager _productManager;
        public SearchModel()
        {
            _productManager = new ProductManager(new ProductDAL());
            SearchResults = new HashSet<Product>();
        }
        public IActionResult OnGet(string query)
        {
            SearchResults = _productManager.Search(query);

            return Page();
        }
    }
}
