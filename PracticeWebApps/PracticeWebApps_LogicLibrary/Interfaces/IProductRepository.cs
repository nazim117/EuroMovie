using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_LogicLibrary.Interfaces
{
    public interface IProductRepository<T> where T : class
    {
        public T[] LoadProduct();
        public T GetProductById(int id);
    }
}
