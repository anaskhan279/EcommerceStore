using EcommerceStore.Shared.Models;

namespace EcommerceStore.Server.Services
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();

        Task<Category> GetCategoryByUrl(string categoryUrl);
    }
}
