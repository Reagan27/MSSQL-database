using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Cart> Carts { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Initial Catalog = EcommerceApp;Trusted_Connection=True; TrustServerCertificate=True; User Id = sa; Password= 1234");
        }


    }




}






