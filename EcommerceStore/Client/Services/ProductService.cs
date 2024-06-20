using EcommerceStore.Shared.Models;

namespace EcommerceStore.Client.Services
{
    public class ProductService : IProductAPI
    {
        public List<Product> Products { get; set; }

        public void LoadProducts()
        {

            Products = new List<Product>
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
}
