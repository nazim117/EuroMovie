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
        public Product(int id, string name, string description, byte[] picture)
        {
            Id = id;
            Name = name;
            Description = description;
            Picture = picture;
        }

        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public byte[] Picture { get; set; }
    }
}
