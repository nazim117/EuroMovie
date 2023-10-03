using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_Domain.Models
{
    public class Review
    {
        public Review(int rating, string description)
        {
            Rating = rating;
            Description = description;
        }

        public int Rating { get; set; }
        public string Description { get; set; }
    }
}
