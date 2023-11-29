using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeWebApps.DTOs;
using PracticeWebApps_DAL_Library;
using PracticeWebApps_LogicLibrary.Managers;
using System.Net.Mail;

namespace PracticeWebApps.Pages
{
    public class ForgotPasswordModel : PageModel
    {
        [BindProperty]
        public CreateAccountDTO CreateAccountDTO { get; set; }
        public string ErrorMessage { get; set; }
        public string PageTitle { get; set; }

        private readonly ILogger<ForgotPasswordModel> _logger;
        public ForgotPasswordModel(ILogger<ForgotPasswordModel> logger)
        {
            _logger = logger;
            PageTitle = "Forgot Password";
            ErrorMessage = string.Empty;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (CreateAccountDTO.Email == null)
            {
                ErrorMessage = "Fill in email";
                return Page();
            }
            UserManager userManager = new UserManager(new UserDAL());

            if (!userManager.FindEmail(CreateAccountDTO.Email))
            {
                ErrorMessage = "Invalid Email";
                return Page();
            }

            EmailSender emailSender = new EmailSender(CreateAccountDTO.Email);
            try
            {
                emailSender.SendEmail();

                TempData["GeneratedCode"] = emailSender.GetGeneratedCode();
                TempData["UserEmail"] = CreateAccountDTO.Email;

                return RedirectToPage("/ConfirmCode");
            }
            catch (SmtpFailedRecipientsException)
            {
                throw new SmtpFailedRecipientsException("There has been an issue with more than one email address");
            }
            catch (SmtpFailedRecipientException)
            {
                throw new SmtpFailedRecipientException("There has been an issue with your email address");
            }
            catch (SmtpException)
            {
                throw new SmtpException("Server error occurred");
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("A problem occurred");
            }
            catch (Exception)
            {
                throw new Exception("An error occurred. Try again later");
            }
        }
    }
}
