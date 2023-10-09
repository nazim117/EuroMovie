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
    }
}
