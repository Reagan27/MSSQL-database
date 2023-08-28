using System;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class Shipment
    {
        [Key]
        public int Id { get; set; }
        public DateTime ShipmentDate { get; set; }
        public string TrackingNumber { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}

