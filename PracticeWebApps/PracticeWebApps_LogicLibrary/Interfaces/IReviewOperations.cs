using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_LogicLibrary.Interfaces
{
    public interface IReviewOperations<T> where T : class
    {
        public bool CreateReview(T t, string userName, string productName);
        public T GetReviewForProduct(int id);
        public T[] LoadReviewsForProduct(int id);
        public T[] LoadReviewsForUser(int id);

    }
}
