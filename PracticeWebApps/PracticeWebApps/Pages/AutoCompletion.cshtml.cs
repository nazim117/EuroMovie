using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.IdentityModel.Tokens;
using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Managers;
using PracticeWebApps_LogicLibrary.SortTypes;

namespace PracticeWebApps.Pages
{
    public class AutoCompletionModel : PageModel
    {
        public JsonResult OnGet(string term)
        {
            ProductManager productManager = new ProductManager(new ProductDAL());
            AlgorithmManager<Product> algorithmManager = new AlgorithmManager<Product>();

            List<Product> matchingMovies = new List<Product>();
            List<string> matchingMovieNames = new List<string>();

            //Complexity - O(n)
            matchingMovies = algorithmManager.SearchProduct(term, productManager.LoadObjects().ToList()).ToList();

            foreach (var item in matchingMovies)
            {
                matchingMovieNames.Add(item.Name);
            }

            return new JsonResult(matchingMovieNames);
        }
    }
}
