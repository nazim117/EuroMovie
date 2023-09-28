using PracticeWebApps_LogicLibrary.Interfaces;
using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models.Users;

namespace PracticeWebApps_LogicLibrary.Managers
{
    public class UserManager
    {
        private IUserRepository<UserModel> userRepository;

        public UserManager(IUserRepository<UserModel> userRepository)
        {
            this.userRepository = userRepository;
        }
        public bool CreateUser(string name, string email, string phone, bool isAdmin, string password, string salt)
        {
            if (!GetUsers().Any(u => u.Email.Equals(email)))
            {
                UserModel user = new UserModel(name, email, phone, isAdmin, password, salt);
                return userRepository.CreateUser(user);
            }
            else
            {
                throw new UserException();
            }
        }
        public UserModel[] GetUsers()
        {
            return userRepository.LoadUsers();
        }
    }
}
