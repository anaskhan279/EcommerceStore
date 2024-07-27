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

  /*      public DbSet<Category> Categories { get; set; }*/
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<ProductVariant>()
               .HasKey(p => new { p.ProductId, p.EditionId });

            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 4, Name = "books", Url = "books", Icon = "book" },
                    new Category { Id = 2, Name = "glasses", Url = "glasses", Icon = "book" },
                    new Category { Id = 3, Name = "bikes", Url = "bikes", Icon = "book" }
                );
*/
            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "first product",
                     Description = "this is some amazing product",
                     Image = "urls",
                     DateCreated = new DateTime(24, 7, 24)
                 },
                new Product
                {
                    Id = 2,
                    Title = "second product",
                    Description = "this is some amazing product",
                    Image = "urls",
                    DateCreated = new DateTime(24, 7, 24)
                },
                new Product
                {
                    Id = 3,
                    Title = "third product",
                    Description = "this is some amazing product",
                    Image = "urls",
                    DateCreated = new DateTime(24, 7, 24)
                },
                new Product
                {
                    Id = 4,
                    Title = "fourth product",
                    Description = "this is some very amazing product",
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

           /* modelBuilder.Entity<ProductVariant>().HasData(
                 new ProductVariant
                 {
                     ProductId = 1,
                     EditionId = 2,
                     Price = 9.99m,
                     OriginalPrice = 19.99m
                 },
                 new ProductVariant
                 {
                     ProductId = 1,
                     EditionId = 3,
                     Price = 7.99m
                 },
                 new ProductVariant
                 {
                     ProductId = 1,
                     EditionId = 4,
                     Price = 19.99m,
                     OriginalPrice = 29.99m
                 },
                 new ProductVariant
                 {
                     ProductId = 2,
                     EditionId = 2,
                     Price = 7.99m,
                     OriginalPrice = 14.99m
                 },
                 new ProductVariant
                 {
                     ProductId = 3,
                     EditionId = 2,
                     Price = 6.99m
                 },
                 new ProductVariant
                 {
                     ProductId = 3,
                     EditionId = 1,
                     Price = 166.66m,
                     OriginalPrice = 249.00m
                 },
                 new ProductVariant
                 {
                     ProductId = 2,
                     EditionId = 1,
                     Price = 159.99m,
                     OriginalPrice = 299m
                 },
                 new ProductVariant
                 {
                     ProductId = 4,
                     EditionId = 1,
                     Price = 73.74m,
                     OriginalPrice = 400m
                 },
                 new ProductVariant
                 {
                     ProductId = 4,
                     EditionId = 5,
                     Price = 19.99m,
                     OriginalPrice = 29.99m
                 }
             );*/
        }
    }
}
