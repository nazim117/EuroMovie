using PracticeWebApps_Domain.Models;
using PracticeWebApps_LogicLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_LogicLibrary.Managers
{
    public class ReviewManager
    {
        private IReviewOperations<Review> operationsRepository;

        public ReviewManager(IReviewOperations<Review> operationsRepository)
        {
            this.operationsRepository = operationsRepository;
        }
        public bool CreateReview(Review review, string userName, string productName)
        {
            return operationsRepository.CreateReview(review, userName, productName);
        }
        public Review GetReview(int id)
        {
            return operationsRepository.GetReviewForProduct(id);
        }
        public Review[] LoadReviewsForProduct(int productId)
        {
            return operationsRepository.LoadReviewsForProduct(productId);
        }
    }
}
