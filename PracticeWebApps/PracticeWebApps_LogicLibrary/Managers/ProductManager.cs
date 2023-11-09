using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Interfaces;

namespace PracticeWebApps_LogicLibrary.Managers
{
    public class ProductManager
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
        public bool EditObject(Product product, string previousName)
        {
            return operationRepository.EditObject(product, previousName);
        }
        public List<Product> MergeSort(List<Product> products)
        {
            if (products.Count <= 1)
            {
                return products;
            }

            int middle = products.Count / 2;

            List<Product> left = new List<Product>(products.GetRange(0, middle));
            List<Product> right = new List<Product>(products.GetRange(middle, products.Count - middle));

            left = MergeSort(left);
            right = MergeSort(right);

            int i = 0, j = 0, k = 0;

            while (i < left.Count && j < right.Count)
            {
                if (string.Compare(left[i].Name, right[i].Name, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    products[k] = left[i];
                    i++;
                }
                else
                {
                    products[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < left.Count)
            {
                products[k] = left[i];
                i++;
                k++;
            }
            while (j < right.Count)
            {
                products[k] = right[j];
                j++;
                k++;
            }
            return products;

        }
        public List<Product> Search(string searchQuery)
        {
            List<Product> result = new List<Product>();
            List<Product> products = LoadObjects().ToList();
            products = MergeSort(products);

            foreach (var product in products)
            {
                if (product.Name.StartsWith(searchQuery,StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(product);
                }
            }
            return result;
        }
        
    } 
}
