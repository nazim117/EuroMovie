using PracticeWebApps_LogicLibrary.Interfaces;
using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models;

namespace PracticeWebApps_LogicLibrary.Managers
{
    public class UserManager
    {
        private IUserOperations<UserModel> operationsRepository;

        public UserManager(IUserOperations<UserModel> operationsRepository)
        {
            this.operationsRepository = operationsRepository;
        }
        public bool CreateObject(UserModel user, string salt)
        {
            if (!operationsRepository.IsUserPresent(user))
            {
                return operationsRepository.CreateObject(user, salt);
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
        public bool EditObject(UserModel user, string previousEmail) 
        {
            return operationsRepository.EditObject(user, previousEmail);
        }
        public bool DeleteObject(UserModel user)
        {
            return operationsRepository.DeleteObject(user);
        }

    }
}
