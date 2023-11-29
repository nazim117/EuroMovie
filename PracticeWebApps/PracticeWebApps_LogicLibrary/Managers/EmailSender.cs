using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_LogicLibrary.Managers
{
    public class EmailSender
    {
        private string _emailTo;
        private string emailFrom, emailPass, messageBody;
        private int code;
        private CodeController codeGenerator;
        private MailMessage message;
        private SmtpClient smtpClient;
        public EmailSender(string emailTo)
        {
            _emailTo = emailTo;
            emailFrom = "mediabazaar464@gmail.com";
            emailPass = "plne tmxx lkfs bpll";
            codeGenerator = new CodeController();
            code = codeGenerator.GenerateCode();
            messageBody = $"Your code is {code}";

            message = new MailMessage();
            message.From = new MailAddress(emailFrom);
            message.To.Add(_emailTo);
            message.CC.Add(emailFrom);
            message.Body = messageBody;
            message.Subject = "Password Reset Code";

            smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Timeout = 5000;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(emailFrom, emailPass);
        }
        public int GetGeneratedCode()=> code;

        public bool SendEmail()
        {
            try
            {
                smtpClient.Send(message);
                return true;
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
        public bool CheckCode(int code) => codeGenerator.IsCodeValid(code);
    }
}
