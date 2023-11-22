using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Interfaces;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PracticeWebApps_UnitTest.FakeDB
{
    public class FakeProductDAL : IOperations<Product>
    {
        private List<Product> _products;
        public FakeProductDAL()
        {
            _products = new List<Product>()
            {
                new Movie("Transformers", "description1", Rating.G, Genre.Action, 120, "picturePath1"),
                new Movie("Transformers 4", "description2", Rating.PG_13, Genre.Action, 140, "picturePath2"),
                new Serie("The Witcher", "description3", Rating.NC_17, Genre.Adventure, 110, "picturePath3", 3, 6)
            };
        }
        public bool CreateObject(Product product)
        {
            if (product != null)
            {
                if (!_products.Any(p => p.Name.Equals(product.Name)))
                {
                    _products.Add(product);
                    return true;
                }
            }
            return false;
        }

        public bool EditObject(Product product, string previousName)
        {
            int index = _products.FindIndex(p => p.Name == previousName);
            if (index == -1)
            {
                return false;
            }
            _products[index] = product;
            return true;
        }

        public Product GetObject(string stringForSearch)
        {
            Product product = _products.Find(p => p.Name == stringForSearch);
            if (product is Movie)
            {
                product = (Movie)product;
            }
            else if(product is Serie)
            {
                product = (Serie)product;
            }
            return product;

        }
//TODO: IMPLEMENT
        public int GetObjectId(string stringForSearch)
        {
            throw new NotImplementedException();
        }

        public bool IsObjectPresent(Product t)
        {
            return _products.Any(n=>n.Name == t.Name);
        }

        public Product[] LoadObjects()
        {
            return _products.ToArray();
        }
    }
}
