using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_Domain.Exceptions
{
    public class UserException : Exception
    {
        public UserException(string message) : base($"There has been an error with the user information: {message}")
        {

        }

        public UserException() : base("A User with this email already exists!")
        {

        }
    }
}
