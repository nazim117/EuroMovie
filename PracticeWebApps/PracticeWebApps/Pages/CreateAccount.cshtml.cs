using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeWebApps.DTOs;
using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_LogicLibrary.Managers;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PracticeWebApps.Pages
{
    public class CreateAccountModel : PageModel
    {
        [BindProperty]
        public CreateAccountDTO CreateAccountDTO { get; set; }
        public string ErrorMessage { get; set; }
        public string PageTitle { get; set; }

        private readonly ILogger<CreateAccountModel> _logger;
        public CreateAccountModel(ILogger<CreateAccountModel> logger)
		{
            _logger = logger;
			PageTitle = "Create Account";
            ErrorMessage = string.Empty;
		}
        public IActionResult OnGet()
        {
            return Page();
        }
		public IActionResult OnPost()
		{
            if (!ModelState.IsValid)
            {
                ErrorMessage = "Account creation failed. Try again later.";
                _logger.LogError(ErrorMessage);
                return Page();
            }
            if (CreateAccountDTO.Password != CreateAccountDTO.ConfirmPassword)
            {
                return Page();
            }
            UserManager userManager = new UserManager( new UserDAL());
            PasswordHashingManager passwordHashing = new PasswordHashingManager();
            string salt = passwordHashing.GetSalt();
            string passHash = passwordHashing.GetHash(CreateAccountDTO.Password, salt);

            try
            {
                userManager.CreateObject(
                    new UserModel(CreateAccountDTO.Name, CreateAccountDTO.Email, CreateAccountDTO.Phone, passHash), salt);
            }
            catch(UserException ex){ _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

            catch (SqlNullValueException ex){ _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

            catch (InvalidOperationException ex){ _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

            catch (SqlException ex){ _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

            catch (TimeoutException ex){ _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

            catch (Exception ex){ _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

            return RedirectToPage("/LogIn");
        }
    }
}
