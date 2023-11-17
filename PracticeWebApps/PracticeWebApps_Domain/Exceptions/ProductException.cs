using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_Domain.Exceptions
{
    public class ProductException : Exception
    {
        public ProductException(string message) : base($"There has been an error with the information {message}")
        {
            
        }

        public ProductException() : base("This movie/series already exists")
        {
            
        }
    }
}
