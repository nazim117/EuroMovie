using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_Domain.Models.Products
{
    public class Movie : Product
    {
        public Movie()
        {
            
        }
        public Movie(string name, string description, Rating movieRating,Genre genre, int duration, string picture) 
            : base(name, description, movieRating, genre, duration, picture)
        {
        }
    }
}
