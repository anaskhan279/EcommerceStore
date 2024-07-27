
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceStore.Shared.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
        public string Image { get; set; }
        public bool IsPublic { get; set; }
        public bool IsDeleted { get; set; }
        public List<ProductVariant> Variants { get; set; } = new List<ProductVariant>();
        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; }
    }
}
