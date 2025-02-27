﻿using PracticeWebApps_Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_LogicLibrary.SortTypes
{
    public class SortByRating : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.MovieRating.CompareTo(y.MovieRating);
        }
    }
}
