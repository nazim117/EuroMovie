using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_Domain.Exceptions
{
    public class MovieException : Exception
    {
        public MovieException(string message) : base($"There has been an error with the movie information {message}")
        {
            
        }

        public MovieException() : base("The movie already exists")
        {
            
        }
    }
}
