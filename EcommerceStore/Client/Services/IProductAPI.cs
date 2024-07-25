using EcommerceStore.Shared.Models;

namespace EcommerceStore.Client.Services
{
    public interface IProductAPI
    {
        List<Product> Products { get; set; }
        Task LoadProducts();
        Task<Product> GetProduct(int id);
    }
}
