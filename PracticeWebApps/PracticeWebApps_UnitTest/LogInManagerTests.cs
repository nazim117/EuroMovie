using PracticeWebApps_LogicLibrary.Managers;
using PracticeWebApps_UnitTest.FakeDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_UnitTest
{
    internal class LogInManagerTests
    {
        private LogInManager logInManager;

        [TestInitialize]
        public void Setup()
        {
            logInManager = new LogInManager(new FakeLogInDAL());
        }
    }
}
