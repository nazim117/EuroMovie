namespace PracticeWebApps_Domain.Models.Products
{
    public class Serie:Product
    {
        public Serie()
        {
            
        }
        public Serie(string name, string description, Rating movieRating,Genre genre, int duration, string picture, int season, int episodes) 
            : base(name, description, movieRating, genre, duration, picture)
        {
            Seasons = season;
            Episodes = episodes;
        }

        public int Seasons { get; private set; }
        public int Episodes { get; private set; }
    }
}
