using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Managers;
using PracticeWebApps_LogicLibrary.SortTypes;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace PracticeWebApps.Pages
{
    public class SearchModel : PageModel
    {
        [BindProperty]
        public string searchQuery { get; set; }
        [BindProperty]
        public string sortingAlgo { get; set; }
        public long TimeTaken { get; set; }
        public HashSet<Product> SearchResults { get; private set; }
        public List<Product> SortResults { get; private set; }
        private AlgorithmManager _algomanager;
        private ProductManager _productManager;
        public SearchModel()
        {
            _algomanager = new AlgorithmManager();
            _productManager = new ProductManager(new ProductDAL());
            SearchResults = new HashSet<Product>();
        }
        public IActionResult OnGet(string query, string algorithm)
        {
            _algomanager.StartTimer();
            if (algorithm == "mergeSort")
            {
                SortResults = _algomanager.MergeSort(_productManager.LoadObjects().ToList(), new SortByName());
            }
            if (algorithm == "quickSort")
            {
                SortResults = _algomanager.QuickSort(_productManager.LoadObjects().ToList(), new SortByName());
            }
            SearchResults = _algomanager.Search(query, SortResults);
            TimeTaken = _algomanager.StopTimer();
            searchQuery = query;

            return Page();
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("/Search",new { query = searchQuery, algorithm = sortingAlgo });
        }
    }
}
