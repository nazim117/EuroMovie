using PracticeWebApps_Domain.Models;
using PracticeWebApps_LogicLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_UnitTest.FakeDB
{
    public class FakeUserDAL : IOperations<UserModel>
    {
        List<UserModel> users;
        public FakeUserDAL()
        {
            users = new List<UserModel>
            {
                new UserModel("name", "example@gmail.com", "0213456789", false, "New12345", "salt"),
                new UserModel("name", "example@gmail.com", "0213456789", false, "New12345", "salt"),
                new UserModel("name", "example@gmail.com", "0213456789", false, "New12345", "salt")
            };
        }
        public UserModel[] LoadObjects()
        {
            if (users != null)
            {
                return users.ToArray();
            }
            return null;
        }
        public UserModel GetObject(string email)
        {
            if (email != string.Empty)
            {
                foreach (UserModel user in users)
                {
                    if (email == user.Email) return user;
                }
            }
            return null;
        }
        public bool CreateObject(UserModel user)
        {
            if (user != null)
            {
                if (!users.Any(u => u.Email.Equals(user.Email)))
                {
                    users.Add(user);
                    return true;
                }
            }
            return false;
        }
    }
}
