using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Primitives;
using Microsoft.Identity.Client;
using PracticeWebApps.DTOs;
using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_LogicLibrary.Managers;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PracticeWebApps.Pages
{
    public class UpdatePasswordModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public string UserEmail { get; set; }
        [BindProperty]
        public string NewPassword { get; set; }
        [BindProperty]
        public string ConfirmPassword { get; set; }
        public string ErrorMessage { get; set; }
        public string PageTitle { get; set; }

        private readonly ILogger<UpdatePasswordModel> _logger;
        public UpdatePasswordModel(ILogger<UpdatePasswordModel> logger)
        {
            _logger = logger;
            PageTitle = "Confirm Code";
            ErrorMessage = string.Empty;
            NewPassword = string.Empty;
            ConfirmPassword = string.Empty;

        }
        public void OnGet()
        {
            UserEmail = (string)TempData["UserEmail"];
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (ConfirmPassword != NewPassword)
            {
                ErrorMessage = "Passwords do not match";
            }

            UserManager userManager = new UserManager(new UserDAL());
            PasswordHashingManager passwordHashing = new PasswordHashingManager();
            string salt = passwordHashing.GenerateSalt();
            string passHash = passwordHashing.GenerateHash(NewPassword, salt);

            try
            {
                userManager.ChangePassword(UserEmail, passHash, salt);
            }
            catch (UserException ex) { _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

            catch (SqlNullValueException ex) { _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

            catch (InvalidOperationException ex) { _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

            catch (SqlException ex) { _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

            catch (TimeoutException ex) { _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

            catch (Exception ex) { _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

            return RedirectToPage("/LogIn");
        }
    }
}
