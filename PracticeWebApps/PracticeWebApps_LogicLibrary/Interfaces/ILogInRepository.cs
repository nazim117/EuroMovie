using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_LogicLibrary.Interfaces
{
    public interface ILogInRepository<T> where T : class
    {
        string GetSalt(string name);
        string GetHashedPassword(string name);
    }
}
