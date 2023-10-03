using PracticeWebApps_Domain.Models.Products;

namespace PracticeWebApps_Domain.Models
{
    public class UserModel
    {
        private static int id = 1;

        public UserModel()
        {

        }
        public UserModel(string name, string email, string phone, bool isAdmin,string password, string salt)
        {
            Id = id++;
            Name = name;
            Email = email;
            Phone = phone;
            IsAdmin = isAdmin;
            Password = password;
            Salt = salt;

            Reviews = new List<Review>();
            WatchList = new List<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsAdmin { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Salt { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Product> WatchList { get; set; }   

        public override string ToString()
        {
            return $"Name: {Name} | Email: {Email} | Phone: {Phone}";
        }
    }
}
