using Azure.Core.GeoJson;
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
        public void OnGet(string name)
        {
            ProductManager productManager = new ProductManager(new ProductDAL());
            Movie = (Movie)productManager.GetObject(name);
        }
    }
}
