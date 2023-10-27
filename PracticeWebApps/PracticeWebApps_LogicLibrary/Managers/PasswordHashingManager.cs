using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace PracticeWebApps_LogicLibrary.Managers
{
    public class PasswordHashingManager
    {
        public PasswordHashingManager()
        {
            
        }
        public string GetSalt()
        {
            var salt = new byte[30];
            using (var random = new RNGCryptoServiceProvider())
            {
                random.GetNonZeroBytes(salt);
            }
             
            return Convert.ToBase64String(salt);
        }

        public string GetHash(string password, string salt)
        {
            return BCrypt.Net.BCrypt.HashPassword(password + salt);
        }

        public bool ValidatePassword(string password, string salt, string passwordHash)
        {
            if (password != null  && salt != null && passwordHash != null)
            {
                return BCrypt.Net.BCrypt.Verify(password + salt, passwordHash);
            }
            return false;
        }
    }
}
