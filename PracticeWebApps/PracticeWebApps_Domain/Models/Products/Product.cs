using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_Domain.Models.Products
{
    public class Product
    {
        private static int id = 1;

        public Product()
        {
            
        }
        public Product(string name, string description, Rating movieRating, int duration, byte[] picture) : this()
        {
            Id = id++;
            Name = name;
            Description = description;
            MovieRating = movieRating;
            Duration = duration;
            Picture = picture;

            StreamedPlatform = new List<string>();
            Reviews = new List<Review>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Rating MovieRating { get; set; }
        public int Duration { get; set; }
        public byte[] Picture { get; set; }
        public List<string> StreamedPlatform { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
