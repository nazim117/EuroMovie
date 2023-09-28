using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using PracticeWebApps.DTOs;
using PracticeWebApps_LogicLibrary.Managers;
using PracticeWebApps_DAL_Library;

namespace PracticeWebApps.Pages
{
    public class LogInModel : PageModel
    {
        [BindProperty]
        public LogInDTO LogIn { get; set; }
        public string ErrorMessage { get; set; }
        public string PageTitle { get; set; }

        private readonly ILogger<LogInModel> _logger;
        public LogInModel(ILogger<LogInModel> logger)
        {
            _logger = logger;
            PageTitle = "Log In";
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
                ErrorMessage = "Login failed. Please check your username and password.";
                _logger.LogError(ErrorMessage);
                return Page();
            }
            LogInManager logInManager = new LogInManager(new LogInDAL());
            string salt = logInManager.GetSalt(LogIn.UserName);
            string hashedPass = logInManager.GetHashedPassword(LogIn.UserName);

            PasswordHashingManager passwordHashing = new PasswordHashingManager();

            if (passwordHashing.ValidatePassword(LogIn.Password, salt, hashedPass))
            {
                //HttpContext.Session.SetString("ID", abbreviation);

                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, LogIn.UserName));
                claims.Add(new Claim("id", "1"));

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

                return Redirect("/Index");
            }

            ErrorMessage = "Login failed. Please check your username and password.";
            return Page();

        }
    }
}
