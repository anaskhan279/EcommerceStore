﻿using EcommerceStore.Shared.Models;
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
    }
}
