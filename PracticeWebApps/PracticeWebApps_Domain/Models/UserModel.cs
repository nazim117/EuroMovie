using PracticeWebApps_Domain.Models.Products;

namespace PracticeWebApps_Domain.Models
{
    public class UserModel
    {
        public UserModel()
        {

        }

        public UserModel(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }

        public UserModel(string name, string email, string phone, string password)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Password = password;

            Reviews = new List<Review>();
            WatchList = new List<Product>();
        }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Password { get; private set; }
        public List<Review> Reviews { get; private set; }
        public List<Product> WatchList { get; private set; }

        public override string ToString()
        {
            return $"Name: {Name} | Email: {Email} | Phone: {Phone}";
        }
    }
}
