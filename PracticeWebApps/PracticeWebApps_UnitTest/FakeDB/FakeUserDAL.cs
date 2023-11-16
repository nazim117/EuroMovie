﻿using PracticeWebApps_Domain.Models;
using PracticeWebApps_LogicLibrary.Interfaces;

namespace PracticeWebApps_UnitTest.FakeDB
{
    public class FakeUserDAL : IUserOperations<UserModel>
    {
        List<UserModel> users;
        public FakeUserDAL()
        {
            users = new List<UserModel>
            {
                new UserModel("name1", "example1@gmail.com", "0684123452", "New12345"),
                // new UserModel("name2", "example2@gmail.com", "0674231235", "Old12345"),
                // new UserModel("name3", "example3@gmail.com", "0682434412", "Current12345")
            };
        }
        public UserModel[] LoadObjects()
        {
            return users.ToArray();
        }
        public bool CreateObject(UserModel user, string salt)
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
        public bool EditObject(UserModel user, string previousEmail)
        {
            int index = users.FindIndex(u=>u.Email == previousEmail);
            if (index == -1)
            {
                return false;
            }
            users[index] = user;
            return true;
        }

        public bool DeleteObject(UserModel user)
        {
            return users.Remove(user);
        }

        public UserModel GetObject(string stringForSearch)
        {
            return users.Find(u=>u.Email == stringForSearch);
        }
    }
}
