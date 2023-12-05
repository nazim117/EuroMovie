using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using System.Diagnostics;

namespace PracticeWebApps_LogicLibrary.Managers
{
    public class AlgorithmManager<T> where T : class
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
        public List<T> MergeSort(List<T> products, IComparer<T> comparer)
        {
            if (products.Count <= 1)
            {

                return products;
            }

            int middle = products.Count / 2;

            List<T> left = new List<T>(products.GetRange(0, middle));
            List<T> right = new List<T>(products.GetRange(middle, products.Count - middle));

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
        public List<T> QuickSort(List<T> products, IComparer<T> comparer)
        {
            if (products.Count <= 1)
            {
                return products;
            }

            int pivotIndex = products.Count / 2;
            T pivot = products[pivotIndex];

            List<T> left = new List<T>();
            List<T> right = new List<T>();

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

            List<T> sortedList = new List<T>();
            sortedList.AddRange(QuickSort(left, comparer));
            sortedList.Add(pivot);
            sortedList.AddRange(QuickSort(right, comparer));

            return sortedList;
        }
        public HashSet<Product> SearchProduct(string searchQuery, List<Product> products)
        {
            HashSet<Product> result = new HashSet<Product>();

            result = products.ToHashSet();

            if (string.IsNullOrWhiteSpace(searchQuery))
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
        public HashSet<UserModel> SearchUser(string searchQuery, List<UserModel> users)
        {
            HashSet<UserModel> result = new HashSet<UserModel>();

            result = users.ToHashSet();

            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return new HashSet<UserModel>();
            }

            foreach (UserModel user in result)
            {
                if (!user.Name.StartsWith(searchQuery, StringComparison.OrdinalIgnoreCase))
                {
                    result.Remove(user);
                }
            }

            return result;
        }
    }
}
