using PracticeWebApps_Domain.Models.Products;

namespace PracticeWebApps_Domain.Models
{
    public class UserModel
    {
        private string name;
        private string email;
        private string phone;
        private string password;

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
        public string Name 
        {
            get => name; private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid Name");
                }
                name = value;
            }
        }
        public string Email 
        {
            get => email; private set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Invalid Email");
                }
                email = value;
            }
        }
        public string Phone 
        {
            get => phone; private set
            {
                if (value.Length < 10)
                {
                    throw new ArgumentException("Invalid Phone");
                }
                phone = value;
            }
        }
        public string Password 
        {
            get=> password; private set
            {
                if (value.Length < 8)
                {
                    throw new ArgumentException("Invalid Password");
                }
                password = value;
            }
        }
        public List<Review> Reviews { get; private set; }
        public List<Product> WatchList { get; private set; }

        public override string ToString()
        {
            return $"{Name} | {Email} | {Phone}";
        }
    }
}
