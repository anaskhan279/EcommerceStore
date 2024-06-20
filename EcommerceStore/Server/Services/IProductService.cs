using EcommerceStore.Shared.Models;

namespace EcommerceStore.Server.Services
{
    public interface IProductService
    {
        Task<List<Product>> FetchProducts();
    }
}
