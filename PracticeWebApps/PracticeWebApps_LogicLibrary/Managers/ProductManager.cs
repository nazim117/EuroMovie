using PracticeWebApps_LogicLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeWebApps_Domain.Models.Products;

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
    }
}
