using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeWebApps_Domain.Models.Users
{
    public class UserModel
    {
        private static int id;

        public UserModel()
        {

        }
        public UserModel(string name, string email, string phone, bool isAdmin, string password, string salt)
        {
            Id = id++;
            Name = name;
            Email = email;
            Phone = phone;
            IsAdmin = isAdmin;
            Password = password;
            Salt = salt;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsAdmin { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Salt { get; set; }
    }
}
