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
//TODO: ReviewManager Tests
        // link between review and product
        // get user review
        // delete user review
        // update user review
    }
}
