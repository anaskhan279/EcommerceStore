using EcommerceStore.Shared.Models;
using System.Net.Http.Json;

namespace EcommerceStore.Client.Services
{
    public class ProductAPI : IProductAPI
    {
        private readonly HttpClient _httpClient;
        public ProductAPI(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public async Task<Product> GetProductById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Product>($"/api/product/{id}");
        }

        public async Task LoadProducts()
        {
            Products = await _httpClient.GetFromJsonAsync<List<Product>>("/api/Product");
        }
    }
}
