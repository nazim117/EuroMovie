using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Interfaces;

namespace PracticeWebApps_LogicLibrary.Managers
{
    public class ProductManager
    {
        private const int MAX_RECENTLY_VIEWED_SIZE = 5;
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
        public int GetObjectId(string name)
        {
            return operationRepository.GetObjectId(name);
        }
        public bool CreateObject(Product product)
        {
            if (!operationRepository.IsObjectPresent(product))
            {
                return operationRepository.CreateObject(product);
            }
            else
            {
                throw new ProductException();
            }
        }
        public bool IsObjectPresent(Product product)
        {
            return operationRepository.IsObjectPresent(product);
        }
        public bool EditObject(Product product, string previousName)
        {
            return operationRepository.EditObject(product, previousName);
        }
        public bool DeleteObject(Product product)
        {
            return operationRepository.DeleteObject(product);
        }

    } 
}
