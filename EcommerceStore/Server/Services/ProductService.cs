using EcommerceStore.Shared.Models;

namespace EcommerceStore.Server.Services
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;

        public ProductService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
       
        public async Task<List<Product>> GetAllProducts()
        {
            return Products;
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return Products.Where(p => p.CategoryId == category.Id).ToList();
        }

        public List<Product> Products { get; set; } = new List<Product>
        {
            new Product
                {
                    Id=1,
                    CategoryId=2,
                    Title="first product",
                    Description="this is some amazing product",
                    Price= (decimal)9.99,
                    OriginalPrice= (decimal)10.99,

                },
                new Product
                {
                    Id=2,
                    CategoryId=3,
                    Title="second product",
                    Description="this is some amazing product",
                    Price= (decimal)9.99,
                    OriginalPrice= (decimal)10.99,
                },
                new Product
                {
                    Id=3,
                    CategoryId=4,
                    Title="third product",
                    Description="this is some amazing product",
                    Price= (decimal)9.99,
                    OriginalPrice= (decimal)10.99,
                },
        };
    }
}
