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
        public void LoadUsers_ReturnsUserArrayAndNotNull()
        {
            UserModel[] users = userManager.LoadObjects();

            Assert.IsNotNull(users);
            Assert.AreEqual(1, users.Length);
        }
        [TestMethod]
        public void CreateUser_ValidUser_ReturnsTrue()
        {
            UserModel user = new UserModel("Valid", "true@email.com", "0612345678", "Pass1234");
            bool created = userManager.CreateObject(user, "salt");

            Assert.IsTrue(created);
        }
        [TestMethod]
        public void DeleteUser_ValidUser_ReturnsTrue()
        {
            UserModel user = userManager.GetObject("example1@gmail.com");
            bool deleted = userManager.DeleteObject(user);

            Assert.IsTrue(deleted);
        }
        [TestMethod]
        public void GetUser_ValidUser_ReturnsNotNull()
        {
            UserModel user = userManager.GetObject("example1@gmail.com");
            
            Assert.IsNotNull(user);
        }
        [TestMethod]
        public void EditUser_ValidUser_ReturnsTrue()
        {
            UserModel newUser = new UserModel("newName", "newEmail@gmail.com", "0683215693");

            bool edited = userManager.EditObject(newUser, "example1@gmail.com");

            Assert.IsTrue(edited);
        }
        [TestMethod]
        public void FindUser_UserExists_ReturnsTrue()
        {
            UserModel newUser = new UserModel("name1", "example1@gmail.com", "0684123452", "New12345");

            bool isFound = userManager.IsUserPresent(newUser);

            Assert.IsTrue(isFound);
        }
        [TestMethod]
        public void GetUserId_UserExists_ReturnsUserId()
        {
            int userId = userManager.GetUserId("name1");

            Assert.AreEqual(userId, 0);
        }
        [TestMethod]
        public void FindEmail_EmailExists_ReturnsTrue()
        {
            bool emailExists = userManager.FindEmail("example1@gmail.com");

            Assert.IsTrue(emailExists);
        }
        [TestMethod]
        public void FindEmail_EmailDoesNotExist_ReturnsFalse()
        {
            bool emailExists = userManager.FindEmail("nonExistent@gmail.com");

            Assert.IsFalse(emailExists);
        }
        [TestMethod]
        public void ChangePassword_UserExists_PasswordChanged_ReturnsTrue()
        {
            bool passwordChanged = userManager.ChangePassword("example1@gmail.com", "newPassword12345", "newSalt123");

            Assert.IsTrue(passwordChanged);

            UserModel updatedUser = userManager.GetObject("example1@gmail.com");

            Assert.AreEqual("newPassword12345newSalt123", updatedUser.Password);
        }
    }
}
