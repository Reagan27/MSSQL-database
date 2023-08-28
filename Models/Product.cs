using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
