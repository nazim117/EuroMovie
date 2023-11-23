using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_LogicLibrary.Interfaces
{
    public interface IUserOperations<T> where T : class
    {
        public T[] LoadObjects();
        public T GetObject(string stringForSearch);
        public bool CreateObject(T t, string salt);
        public bool EditObject(T t, string previousEmail);
        public bool DeleteObject(T t);
        public bool IsUserPresent(T t);
        public int GetUserId(string searchString);
    }
}
