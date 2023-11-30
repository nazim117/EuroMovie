using PracticeWebApps_Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_LogicLibrary.Managers
{
    public class AlgorithmManager
    {
        private Stopwatch stopwatch;
        public long ElapsedTime { get; private set; }

        public void StartTimer()
        {
            stopwatch = new Stopwatch();

            stopwatch.Start();
        }
        public long StopTimer()
        {
            return ElapsedTime = stopwatch.ElapsedMilliseconds;
        }
        public List<Product> MergeSort(List<Product> products, IComparer<Product> comparer)
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
        public List<Product> QuickSort(List<Product> products, IComparer<Product> comparer)
        {
            if (products.Count <= 1)
            {
                return products;
            }

            int pivotIndex = products.Count / 2;
            Product pivot = products[pivotIndex];

            List<Product> left = new List<Product>();
            List<Product> right = new List<Product>();

            for (int i = 0; i < products.Count; i++)
            {
                if (i == pivotIndex)
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
            sortedList.AddRange(QuickSort(left, comparer));
            sortedList.Add(pivot);
            sortedList.AddRange(QuickSort(right, comparer));

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
                if (!product.Name.StartsWith(searchQuery, StringComparison.OrdinalIgnoreCase))
                {
                    result.Remove(product);
                }
            }

            return result;
        }
    }
}
