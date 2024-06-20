using EcommerceStore.Shared.Models;

namespace EcommerceStore.Server.Services
{
    public interface ICategoryService
    {
        Task<List<Category>> FetchCategories();
    }
}
