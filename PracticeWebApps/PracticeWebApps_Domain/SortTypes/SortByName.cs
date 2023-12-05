using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_LogicLibrary.SortTypes
{
    public class SortByName : IComparer<Product>, IComparer<UserModel>
    {
        public int Compare(Product x, Product y)
        {
            return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
        }

        public int Compare(UserModel x, UserModel y)
        {
            return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}
