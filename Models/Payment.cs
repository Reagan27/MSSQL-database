using System;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
