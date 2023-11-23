using PracticeWebApps_Domain.Models;
using PracticeWebApps_LogicLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_UnitTest.FakeDB
{
    public class FakeReviewDAL : IReviewOperations<Review>
    {
//TODO: IMPLEMENT
        public bool CreateReview(Review t, string userName, string productName)
        {
            throw new NotImplementedException();
        }

        public Review GetReviewForProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Review[] LoadReviewsForProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Review[] LoadReviewsForUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
