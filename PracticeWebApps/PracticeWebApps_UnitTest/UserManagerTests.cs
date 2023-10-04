using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_LogicLibrary.Managers;
using PracticeWebApps_UnitTest.FakeDB;

namespace PracticeWebApps_UnitTest
{
    [TestClass]
    public class UserManagerTests
    {
        private UserManager userManager;

        [TestInitialize]
        public void Setup()
        {
            userManager = new UserManager(new FakeUserDAL());
        }

        [TestMethod]
        public void LoadUsers_ReturnsUserArray()
        {
            UserModel[] users = userManager.LoadObjects();

            Assert.IsNotNull(users);
            Assert.AreEqual(3, users.Length);
        }
        [TestMethod]
        public void CreateUser_ValidUser_ReturnsTrue()
        {
            UserModel user = new UserModel("Valid", "true@email.com", "0612345678", false, "Pass1234", "salt");
            bool created = userManager.CreateObject(user);

            Assert.IsTrue(created);
        }
    }
}
