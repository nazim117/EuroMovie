using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Managers;

namespace PracticeWebApps.Pages
{
    public class ProductPageModel : PageModel
    {
        public Movie Movie { get; set; }
        public Serie Series { get; set; }
        public IActionResult OnGet(string name)
        {
            ProductManager productManager = new ProductManager(new ProductDAL());
            if (productManager.GetObject(name) is Movie)
            {
                Movie = (Movie)productManager.GetObject(name);
            }
            else
            {
                Series = (Serie)productManager.GetObject(name);
            }
            return Page();
        }
    }
}
