using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeWebApps.DTOs;
using PracticeWebApps_DAL_Library;
using PracticeWebApps_LogicLibrary.Managers;

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
            
            userManager.CreateUser(CreateAccountDTO.Name, CreateAccountDTO.Email, CreateAccountDTO.Phone, false, passHash, salt);

            return RedirectToPage("/LogIn");
        }
    }
}
