using PracticeWebApps_Domain.Exceptions;
using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Interfaces;
using PracticeWebApps_LogicLibrary.SortTypes;
using System.Diagnostics;
using System.Runtime;

namespace PracticeWebApps_LogicLibrary.Managers
{
    public class ProductManager
    {
        private IOperations<Product> operationRepository;
        private long elapsedTime;
        Stopwatch stopwatch;
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

        /*private void StartTimer()
        {
            stopwatch = new Stopwatch();

            stopwatch.Start();
        }
        private void StopTimer()
        {
            elapsedTime = stopwatch.ElapsedMilliseconds;
        }
        public long GetElapsedTime()
        {
            return elapsedTime;
        }
        public List<Product> MergeSort(List<Product> products, IComparer<Product> comparer)
        {
            if (products.Count <= 1)
            {
                return products;
            }
            StartTimer();

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

            StopTimer();

            return products;

        }
        public List<Product> QuickSort(List<Product> products, IComparer<Product> comparer)
        {
            if (products.Count <= 1)
            {
                return products;
            }
            StartTimer();

            int pivotIndex = products.Count / 2;
            Product pivot = products[pivotIndex];

            List<Product> left = new List<Product>();
            List<Product> right = new List<Product>();

            for (int i = 0; i < products.Count; i++)
            {
                if (i==pivotIndex)
                {
                    continue;
                }

                if (comparer.Compare(products[i], pivot) < 0)
                {
                    left.Add(products[i]);
                }
                else
                {
                    right.Add(products[i]);
                }
            }

            List<Product> sortedList = new List<Product>();
            sortedList.AddRange(QuickSort(left,comparer));
            sortedList.Add(pivot);
            sortedList.AddRange(QuickSort(right,comparer));

            StopTimer();

            return sortedList;
        }
        public HashSet<Product> Search(string searchQuery, List<Product> products)
        {
            HashSet<Product> result = new HashSet<Product>();
            
            result = products.ToHashSet();

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
        }*/
    } 
}
