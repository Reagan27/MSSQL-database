using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }

        public ICollection<Cart> Carts { get; set; }
    }
}

