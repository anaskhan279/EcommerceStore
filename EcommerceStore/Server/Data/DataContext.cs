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
        public DbSet<Edition> Editions { get; set; }

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
                     DateCreated = new DateTime(24, 7, 24)
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
                    DateCreated = new DateTime(24, 7, 24)
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
                    DateCreated = new DateTime(24, 7, 24)
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 4,
                    Title = "fourth product",
                    Description = "this is some very amazing product",
                    Price = (decimal)7.99,
                    OriginalPrice = (decimal)10.99,
                    Image = "urls",
                    DateCreated = new DateTime(24, 7, 24)
                }
                );
         
            modelBuilder.Entity<Edition>().HasData(
                 new Edition { Id = 1, Name = "Papaer-back" },
                 new Edition { Id = 2, Name = "e-book" },
                 new Edition { Id = 3, Name = "X-master" },
                 new Edition { Id = 4, Name = "pc" },
                 new Edition { Id = 5, Name = "P-hub" },
                 new Edition { Id = 6, Name = "Only-fans" }
                );

            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("EditionProduct").HasData(
                new {EditionsId = 1, ProductsId=1},
                new { EditionsId = 1, ProductsId = 2},
                new { EditionsId = 1, ProductsId = 3},
                new { EditionsId = 2, ProductsId = 1},
                new { EditionsId = 2, ProductsId = 2},
                new { EditionsId = 3, ProductsId = 3},
                new { EditionsId = 4, ProductsId = 3},
                new { EditionsId = 5, ProductsId = 4},
                new { EditionsId = 6, ProductsId = 4}
                );
        }
    }
}
