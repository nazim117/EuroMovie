using PracticeWebApps_Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_LogicLibrary.SortTypes
{
    public class SortByGenre : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Genre.CompareTo(y.Genre);
        }
    }
}
