using PracticeWebApps_Domain.Models;
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
        private List<UserModel> users;
        public FakeLogInDAL()
        {
            users = new List<UserModel>
            {
                new UserModel("name1", "example1@gmail.com", "0684123452", "New12345")
            };
        }
        public string GetSalt(string name)
        {
            if (!users.Any(u => u.Name.Equals(name)))
            {
                return string.Empty;
            }
            return "exampleSalt";
        }
        public string GetHashedPassword(string name)
        {
            if (!users.Any(u => u.Name.Equals(name)))
            {
                return string.Empty;
            }
            return "ExamplePassword1234";
        }
    }
}
