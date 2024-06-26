﻿using EcommerceStore.Shared.Models;

namespace EcommerceStore.Server.Services
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>
                {
                    new Category { Id = 4, Name="books" },
                    new Category { Id = 2, Name="glasses" },
                    new Category { Id = 3, Name="bikes" }
                };
        public async Task<List<Category>> FetchCategories()
        {
            return Categories;
        }
    }
}
