using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Interfaces;
using PracticeWebApps_LogicLibrary.SortTypes;

namespace PracticeWebApps_LogicLibrary.Managers
{
    public class ProductManager
    {
        private IOperations<Product> operationRepository;
        private List<Product> products;
        public ProductManager(IOperations<Product> operationRepository)
        {
            this.operationRepository = operationRepository;
            products = LoadObjects().ToList();
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
        private List<Product> MergeSort(List<Product> products, IComparer<Product> comparer)
        {
            if (products.Count <= 1)
            {
                return products;
            }

            int middle = products.Count / 2;

            List<Product> left = new List<Product>(products.GetRange(0, middle));
            List<Product> right = new List<Product>(products.GetRange(middle, products.Count - middle));

            left = MergeSort(left, comparer);
            right = MergeSort(right, comparer);

            int i = 0, j = 0, k = 0;

            while (i < left.Count && j < right.Count)
            {
                if (comparer.Compare(left[i], right[j]) < 0)
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
        public HashSet<Product> Search(string searchQuery, IComparer<Product> comparer)
        {
            HashSet<Product> result = new HashSet<Product>();
            
            result = MergeSort(products, comparer).ToHashSet();

            if (searchQuery == null)
            {
                return new HashSet<Product>();
            }

            foreach (var product in result)
            {
                if (!product.Name.StartsWith(searchQuery,StringComparison.OrdinalIgnoreCase))
                {
                    result.Remove(product);
                }
            }
            
            return result;
        }
        
    } 
}
