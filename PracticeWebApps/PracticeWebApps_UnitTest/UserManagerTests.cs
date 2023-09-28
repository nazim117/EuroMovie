using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models.Users;
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
            UserModel[] users = userManager.GetUsers();

            Assert.IsNotNull(users);
            Assert.AreEqual(3, users.Length);
        }
        [TestMethod]
        public void CreateUser_ValidUser_ReturnsTrue()
        {

            bool created = userManager.CreateUser("Valid", "true@email.com", "0612345678", false, "Pass1234", "salt");

            Assert.IsTrue(created);
        }
    }
}
