using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Managers;
using PracticeWebApps_UnitTest.FakeDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_UnitTest
{
    [TestClass]
    public class LogInManagerTests
    {
        private LogInManager logInManager;

        [TestInitialize]
        public void Setup()
        {
            logInManager = new LogInManager(new FakeLogInDAL());
        }
        [TestMethod]
        public void GetSalt_ValidUserName_ReturnsAreEqual()
        {
            string salt = logInManager.GetSalt("name1");

            Assert.AreEqual(salt, "exampleSalt");
        }
        [TestMethod]
        public void GetHash_ValidUserName_ReturnsAreEqual()
        {
            string hashedPassword = logInManager.GetHashedPassword("name1");

            Assert.AreEqual(hashedPassword, "ExamplePassword1234");
        }
        [TestMethod]
        public void GetSalt_InvalidUserName_ReturnsAreNotEqual()
        {
            string salt = logInManager.GetSalt("FakeName");

            Assert.AreNotEqual(salt, "exampleSalt");
        }
        [TestMethod]
        public void GetHash_InvalidUserName_ReturnsAreNotEqual()
        {
            string hashedPassword = logInManager.GetHashedPassword("FakeName");

            Assert.AreNotEqual(hashedPassword, "ExamplePassword1234");
        }
    }
}
