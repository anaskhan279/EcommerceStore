using EcommerceStore.Shared.Models;

namespace EcommerceStore.Client.Services
{
    public interface ICategoryAPI
    {
        List<Category> Categories { get; set; }
        Task LoadCategories();
    }
}
