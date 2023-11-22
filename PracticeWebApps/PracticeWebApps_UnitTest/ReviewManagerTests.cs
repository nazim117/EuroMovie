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
    public class ReviewManagerTests
    {
        private ReviewManager reviewManager;

        [TestInitialize]
        public void Setup()
        {
            reviewManager = new ReviewManager(new FakeReviewDAL());
        }
//TODO: ReviewManager Tests
        // link between review and product
        // get user review
        // delete user review
        // update user review
    }
}
