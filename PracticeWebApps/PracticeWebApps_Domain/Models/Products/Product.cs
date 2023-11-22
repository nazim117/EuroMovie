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
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public Rating MovieRating { get; protected set; }
        public Genre Genre { get; protected set; }
        public int Duration { get; protected set; }
        public string Picture { get; protected set; }
        public List<string> StreamedPlatform { get; protected set; }
        public List<Review> Reviews { get; protected set; }

        public void AddReview(Review review)
        {
            Reviews.Add(review);
        }
        public override string ToString()
        {
            return $"{Name} | Genre: {Genre} | Rating: {MovieRating} | Duration: {Duration}";
        }
    }
}
