using EcommerceStore.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EcommerceStore.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 4, Name = "books", Url="books", Icon="book" },
                    new Category { Id = 2, Name = "glasses", Url = "glasses", Icon = "book" },
                    new Category { Id = 3, Name = "bikes", Url = "bikes", Icon = "book" }
                );
            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     CategoryId = 2,
                     Title = "first product",
                     Description = "this is some amazing product",
                     Price = (decimal)9.99,
                     OriginalPrice = (decimal)10.99,
                     Image = "urls",
                 },
                new Product
                {
                    Id = 2,
                    CategoryId = 3,
                    Title = "second product",
                    Description = "this is some amazing product",
                    Price = (decimal)9.99,
                    OriginalPrice = (decimal)10.99,
                    Image = "urls",
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 4,
                    Title = "third product",
                    Description = "this is some amazing product",
                    Price = (decimal)9.99,
                    OriginalPrice = (decimal)10.99,
                    Image = "urls",
                }
                );
        }
    }
}
