using EcommerceStore.Server.Data;
using EcommerceStore.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceStore.Server.Services
{
    /*public class ProductService : IProductService
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
            return await _context.Products.Include(p=>p.Variants).ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = await _context.Products.Include(p => p.Variants).ThenInclude(v => v.Edition).FirstOrDefaultAsync(p => p.Id == id);
            return product;
        }

    }*/
}
