using EcommerceStore.Shared.Models;

namespace EcommerceStore.Client.Services
{
    public class CategoryService : ICategoryAPI
    {
        public List<Category> Categories { get ; set ; }

        public void LoadCategories()
        {
            Categories = new List<Category>
            {
                new Category { Id = 4, Name="books" },
                new Category { Id = 2, Name="glasses" },
                new Category { Id = 3, Name="bikes" }
            };
        }
    }
}
