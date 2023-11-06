using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Interfaces;

namespace PracticeWebApps_LogicLibrary.Managers
{
    public class ProductManager : IOperations<Product>
    {
        private IOperations<Product> operationRepository;

        public ProductManager(IOperations<Product> operationRepository)
        {
            this.operationRepository = operationRepository;
        }

        public Product[] LoadObjects()
        {
            return operationRepository.LoadObjects();
        }
        public Product GetObject(string name)
        {
            return operationRepository.GetObject(name);
        }
        public bool CreateObject(Product product)
        {
            if (!LoadObjects().Any(u => u.Name.Equals(product.Name)))
            {
                return operationRepository.CreateObject(product);
            }
            else
            {
                throw new MovieException();
            }
        }
        private delegate int NameComparisonDelegate(Product product, string targetName);
        public List<Product> BinarySearch(string searchQuery)
        {
            List<Product> result = new List<Product>();
            List<Product> products = LoadObjects().ToList();
            int left = 0;
            int right = products.Count - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                Product midProduct = products[mid];

                NameComparisonDelegate comparer = (midProduct, searchQuery) => string.Compare(midProduct.Name,searchQuery, StringComparison.Ordinal);
                
                int comparison = comparer(midProduct, searchQuery);

                if (comparison == 0)
                {
                    result.Add(midProduct);
                }
                if (comparison < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return result;
        }

        public bool EditObject(Product product)
        {
            return operationRepository.EditObject(product);
        }
    }
}
