using PracticeWebApps_Domain.Exceptions;
using System.Xml.Linq;

namespace PracticeWebApps_Domain.Models.Products
{
    public class Serie:Product
    {
        private int seasons;
        private int episodes;

        public Serie()
        {
            
        }
        public Serie(string name, string description, Rating movieRating,Genre genre, int duration, string picture, int season, int episodes) 
            : base(name, description, movieRating, genre, duration, picture)
        {
            Seasons = season;
            Episodes = episodes;
        }

        public int Seasons {
            get => seasons; 
            protected set
            {
                if (value < 0 || value > 100)
                {
                    throw new NumberOutOfRangeException("Number out of range. Please enter a number between 0 and 100.");
                }
                seasons = value;
            }
        }
        public int Episodes {
            get => episodes; 
            protected set
            {
                if (value < 0 || value > 700)
                {
                    throw new NumberOutOfRangeException("Number out of range. Please enter a number between 0 and 700.");
                }
                episodes = value;
            }
        }
    }
}
