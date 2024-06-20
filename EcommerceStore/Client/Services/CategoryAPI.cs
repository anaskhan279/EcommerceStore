using EcommerceStore.Shared.Models;
using System.Net.Http.Json;

namespace EcommerceStore.Client.Services
{
    public class CategoryAPI : ICategoryAPI
    {
        private readonly HttpClient _http;
        public CategoryAPI(HttpClient http)
        {
            _http = http;
        }
        public List<Category> Categories { get ; set ; } = new List<Category>();

        public async Task LoadCategories()
        {
            Categories = await _http.GetFromJsonAsync<List<Category>>("/api/Category");
        }
    }
}
