using EcommerceStore.Server.Data;
using EcommerceStore.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceStore.Server.Services
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _context;
        public ProductService(ICategoryService categoryService, DataContext dataContext)
        {
            _categoryService = categoryService;
            _context = dataContext;
        }
       
        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = await _context.Products.Include(p => p.Editions).FirstOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return await _context.Products.Where(p => p.CategoryId == category.Id).ToListAsync();
        }

    }
}
