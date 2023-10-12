using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_Domain.Exceptions
{
    public class NumberOutOfRangeException : Exception
    {
        public NumberOutOfRangeException(string message) : base(message) { }
    }
}
