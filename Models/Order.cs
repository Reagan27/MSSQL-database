using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}

