using PracticeWebApps_Domain.Models.Users;
using PracticeWebApps_LogicLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_UnitTest.FakeDB
{
    public class FakeLogInDAL : ILogInRepository<UserModel>
    {
        public string GetSalt(string name)
        {
            return "exampleSalt";
        }
        public string GetHashedPassword(string name)
        {
            
            return "ExamplePassword1234";
        }
    }
}
