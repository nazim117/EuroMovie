using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_Domain.Models.Products
{
    public abstract class Product
    {
        public Product()
        {
            
        }
        public Product(string name, string description, Rating movieRating, Genre genre, int duration, string picture) : this()
        {
            Name = name;
            Description = description;
            MovieRating = movieRating;
            Genre = genre;
            Duration = duration;
            Picture = picture;

            StreamedPlatform = new List<string>();
            Reviews = new List<Review>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public Rating MovieRating { get; set; }
        public Genre Genre { get; set; }
        public int Duration { get; set; }
        public string Picture { get; set; }
        public List<string> StreamedPlatform { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
