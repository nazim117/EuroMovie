using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeWebApps.DTOs;
using PracticeWebApps_DAL_Library;
using PracticeWebApps_Domain;
using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_LogicLibrary.Managers;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Reflection.Emit;

namespace PracticeWebApps.Pages
{
    public class UserProfileModel : PageModel
    {
        [BindProperty]
        public string ErrorMessage { get; private set; }
        [BindProperty]
        public string InfoMessage { get; private set; }
        [BindProperty]
        public UserModel User { get; private set; }

        private UserManager _userManager;

        private readonly ILogger<UserProfileModel> _logger;
        public UserProfileModel(ILogger<UserProfileModel> logger)
        {
            _logger = logger;
            ErrorMessage = string.Empty;
            _userManager = new UserManager(new UserDAL());
        }
        public IActionResult OnGet(string name)
        {
            User = _userManager.GetObject(name);

            return Page();
        }
        public IActionResult OnPost(string name, string email, string phone,string previousEmail)
        {
            try
            {
                if (_userManager.EditObject(new UserModel(name, email, phone), previousEmail))
                {
                    _logger.LogInformation("Saved Changes");
                    User = _userManager.GetObject(name);

                }
                else
                {
                    _logger.LogError("Error Occured");
                }
            }
            catch (SqlNullValueException ex) { _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

            catch (InvalidOperationException ex) { _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

            catch (SqlException ex) { _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

            catch (TimeoutException ex) { _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

            catch (Exception ex) { _logger.LogError(ex.Message); ErrorMessage = ex.Message; return Page(); }

            return Page();
        }
    }
}
