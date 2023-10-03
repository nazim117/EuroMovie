using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Interfaces;

namespace PracticeWebApps_LogicLibrary.Managers
{
    public class ProductManager
    {
        private IProductRepository<Product> productRepository;

        public ProductManager(IProductRepository<Product> productRepository)
        {
            this.productRepository = productRepository;
        }

        public Product[] LoadProduct()
        {
            return productRepository.LoadProduct();
        }
        public Product GetProductById(int id)
        {
            return productRepository.GetProductById(id);
        }
        public bool Create(string name, string description, Rating movieRating, int duration, byte[] picture)
        {
            if (!LoadProduct().Any(u => u.Name.Equals(name)))
            {
                Product product = new Product(name, description, movieRating, duration, picture);
                return productRepository.Create(product);
            }
            else
            {
                throw new MovieException();
            }
        }
    }
}
