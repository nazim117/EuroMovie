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
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Rating MovieRating { get; private set; }
        public Genre Genre { get; private set; }
        public int Duration { get; private set; }
        public string Picture { get; private set; }
        public List<string> StreamedPlatform { get; private set; }
        public List<Review> Reviews { get; private set; }

        public override string ToString()
        {
            return $"{Name} | Genre: {Genre} | Rating: {MovieRating} | Duration: {Duration}";
        }
    }
}
