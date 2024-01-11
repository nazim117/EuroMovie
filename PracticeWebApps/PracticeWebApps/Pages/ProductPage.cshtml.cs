using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeWebApps.DTOs;
using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Managers;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;

namespace PracticeWebApps.Pages
{
    public class ProductPageModel : PageModel
    {

        [BindProperty]
        public string searchQuery { get; set; }
        [BindProperty]
        public string sortingAlgo { get; set; }
        [BindProperty]
        public ReviewDTO Review { get; set; }
        public string ErrorMessage { get; private set; }
        public Product Product { get; private set; }
        public List<Review> Reviews { get; set; }

        private readonly ILogger<ProductPageModel> _logger;
        private ReviewManager reviewManager;
        private readonly ProductManager productManager;
        public ProductPageModel(ILogger<ProductPageModel> logger)
        {
            Review = new ReviewDTO();
            ErrorMessage = string.Empty;
            _logger = logger;
            reviewManager = new ReviewManager(new ReviewDAL());
            productManager = new ProductManager(new ProductDAL());
            Reviews = new List<Review>();
        }
        public IActionResult OnGet(string name)
        {
            int productId = productManager.GetObjectId(name);
            Reviews = reviewManager.LoadReviewsForProduct(productId).ToList();
            Product = productManager.GetObject(name);

            return Page();
        }
        public ProductManager GetProductManager() => productManager;
        public IActionResult OnPost(string productName)
        {

            var userNameClaim = User.FindFirst(ClaimTypes.Name);

            if (userNameClaim != null)
            {
                string userName = userNameClaim.Value;

                try
                {
                    reviewManager.CreateReview(new Review(Review.Rating, Review.Description), userName, productName);
                    _logger.LogInformation("Review Saved");
                }
                catch (SqlNullValueException ex) { _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

                catch (InvalidOperationException ex) { _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

                catch (SqlException ex) { _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

                catch (TimeoutException ex) { _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

                catch (Exception ex) { _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }
            }
            else
            {
                ErrorMessage = "LogIn to give rating";
                _logger.LogError("LogIn to give rating");
            }

            int productId = productManager.GetObjectId(productName);
            Reviews = reviewManager.LoadReviewsForProduct(productId).ToList();
            Product = productManager.GetObject(productName);

            return Page();
            //return RedirectToPage("/ProductPage", new { name = productName });
        }
        public IActionResult OnPostSearch()
        {
            return RedirectToPage("/Search", new { query = searchQuery, algorithm = sortingAlgo });
        }
    }
}
