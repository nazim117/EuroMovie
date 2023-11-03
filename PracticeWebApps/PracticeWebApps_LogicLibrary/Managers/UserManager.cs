using PracticeWebApps_LogicLibrary.Interfaces;
using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models;

namespace PracticeWebApps_LogicLibrary.Managers
{
    public class UserManager
    {
        private IOperations<UserModel> operationsRepository;

        public UserManager(IOperations<UserModel> operationsRepository)
        {
            this.operationsRepository = operationsRepository;
        }
        public bool CreateObject(UserModel user)
        {
            if (!LoadObjects().Any(u => u.Email.Equals(user.Email)))
            {
                return operationsRepository.CreateObject(user);
            }
            else
            {
                throw new UserException();
            }
        }
        public UserModel[] LoadObjects()
        {
            return operationsRepository.LoadObjects();
        }
        public UserModel GetObject(string stringForSearch)
        {
            return operationsRepository.GetObject(stringForSearch);
        }

    }
}
