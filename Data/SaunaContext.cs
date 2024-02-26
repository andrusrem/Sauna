using Microsoft.EntityFrameworkCore;
using Sauna.Models;
namespace Sauna.Data
{
    public class SaunaContext : DbContext
    {
        public SaunaContext(DbContextOptions<SaunaContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<BookedTime> BookedTimes { get; set; }
        public DbSet<Order> Orders { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<BookedTime>().ToTable("BookedTime");
            modelBuilder.Entity<Order>().ToTable("Order");
        }
    }
}