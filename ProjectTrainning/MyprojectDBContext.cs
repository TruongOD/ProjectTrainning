using Microsoft.EntityFrameworkCore;
using ProductManager.Entity;
using ProjectTrainning.Entities;

namespace ProjectTrainning
{
    public class MyprojectDBContext : DbContext
    {
        public MyprojectDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProductMaping> OrderProductMapings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}