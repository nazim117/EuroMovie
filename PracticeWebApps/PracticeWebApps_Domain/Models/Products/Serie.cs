namespace PracticeWebApps_Domain.Models.Products
{
    public class Serie:Product
    {
        public Serie(string name, string description, Rating movieRating, int duration, byte[] picture, int season, int episodes) 
            : base(name, description, movieRating, duration, picture)
        {
            Seasons = season;
            Episodes = episodes;
        }

        public int Seasons { get; set; }
        public int Episodes { get; set; }
    }
}
