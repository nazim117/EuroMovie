using PracticeWebApps_Domain.Exceptions;
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
        private string name;
        private string description;
        private Rating rating;
        private Genre genre;
        private int duration;
        private string picture;

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
        public string Name 
        { 
            get => name; protected set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("Name is too short");
                }
                name = value;
            }
        }
        public string Description { get => description; protected set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("Description is too short");
                }
                description = value;
            }
        }
        public Rating MovieRating { get => rating; protected set
            {
                if (!Enum.IsDefined(typeof(Rating), value))
                {
                    throw new ArgumentException("Invalid rating");

                }
                rating = value;

            } 
        }
        public Genre Genre 
        { 
            get => genre; protected set
            {
                if (!Enum.IsDefined(typeof(Genre), value))
                {
                    throw new ArgumentException("Invalid rating");

                }
                genre = value;
            }
        }
        public int Duration { get => duration; protected set
            {
                if (value < 0 || value > 1000)
                {
                    throw new NumberOutOfRangeException("Number out of range. Please enter a number between 0 and 1000.");
                }
                duration = value;
            } }
        public string Picture 
        { 
            get => picture; protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid Picture");
                }
                picture = value;
            }
        }
        public List<string> StreamedPlatform { get; protected set; }
        public List<Review> Reviews { get; protected set; }

        public override string ToString()
        {
            return $"{Name} | Genre: {Genre} | Rating: {MovieRating} | Duration: {Duration}";
        }
    }
}
