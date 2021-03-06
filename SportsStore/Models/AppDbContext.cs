using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class AppDbContext : DbContext
    {

        //fields and props



        public DbSet<Product> Products { get; set; }

        //contructors

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //methods

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Kayak",
                Description = "A 1 Person Boat",
                Category = "Watersports",
                Price = 275M
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Life Jacket",
                Description = "Protective & Fashionable",
                Category = "Watersports",
                Price = 48.95M
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Corner Flags",
                Description = "Like The Pros",
                Category = "Soccer",
                Price = 19.50M
            });

            modelBuilder.Entity<Product>().HasData
               (new Product
               {
                   ProductId = 5,
                   Name = "Running Shoes",
                   Description = "A New Level Of Comfort",
                   Category = "Running",
                   Price = 89.95M
               });

            modelBuilder.Entity<Product>().HasData
               (new Product
               {
                   ProductId = 6,
                   Name = "Football",
                   Description = "Broncos Logo",
                   Category = "Football",
                   Price = 59.95M
               });



        }
    }
}
