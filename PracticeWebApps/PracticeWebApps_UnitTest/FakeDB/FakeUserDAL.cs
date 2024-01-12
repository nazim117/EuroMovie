using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Interfaces;

namespace PracticeWebApps_UnitTest.FakeDB
{
    public class FakeUserDAL : IUserOperations<UserModel>
    {
        private List<UserModel> users;
        public FakeUserDAL()
        {
            users = new List<UserModel>
            {
                new UserModel("name1", "example1@gmail.com", "0684123452", "New12345")
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

        public bool IsUserPresent(UserModel t)
        {
            return users.Any(n => n.Email == t.Email);
        }
        public int GetUserId(string searchString)
        {
            UserModel user = users.FirstOrDefault(u => u.Name == searchString);

            if (user is not null)
            {
                return users.IndexOf(user);
            }
            else
            {
                return 0;
            }
        }

        public bool FindEmail(string email)
        {
            return users.Any(u=>u.Email == email);
        }

        public bool ChangePassword(string email, string password, string salt)
        {
            UserModel userToupdate = users.FirstOrDefault(u=>u.Email == email);

            if (userToupdate is not null)
            {
                UserModel updatedUser = new UserModel(userToupdate.Name,userToupdate.Email,userToupdate.Phone, password + salt);
                users.RemoveAt(0);
                users.Add(updatedUser);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
