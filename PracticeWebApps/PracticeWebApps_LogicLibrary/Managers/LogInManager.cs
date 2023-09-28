using PracticeWebApps_Domain.Models.Users;
using PracticeWebApps_LogicLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_LogicLibrary.Managers
{
    public class LogInManager
    {
        private ILogInRepository<UserModel> logInRepository;

        public LogInManager(ILogInRepository<UserModel> logInRepository)
        {
            this.logInRepository = logInRepository;
        }
        public string GetSalt(string name)
        {
            return logInRepository.GetSalt(name);
        }
        public string GetHashedPassword(string name)
        {
            return logInRepository.GetHashedPassword(name);
        }
    }
}
