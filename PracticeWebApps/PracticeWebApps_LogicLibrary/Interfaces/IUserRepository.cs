using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_LogicLibrary.Interfaces
{
    public interface IUserRepository<T> where T : class
    {
        public T[] LoadUsers();
        public T GetUser(string email);
        public bool CreateUser(T t);
    }
}
