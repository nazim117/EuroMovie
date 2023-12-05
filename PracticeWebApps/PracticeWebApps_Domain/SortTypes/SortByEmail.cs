using PracticeWebApps_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_Domain.SortTypes
{
    public class SortByEmail : IComparer<UserModel>
    {
        public int Compare(UserModel x, UserModel y)
        {
            return string.Compare(x.Email, y.Email, StringComparison.OrdinalIgnoreCase);

        }
    }
}
