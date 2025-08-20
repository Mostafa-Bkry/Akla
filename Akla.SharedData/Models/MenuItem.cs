using System.ComponentModel.DataAnnotations;

namespace Akla.SharedData.Models
{
    public class MenuItem : BaseEntity
    {
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        public decimal Price { get; set; }

        public bool Available { get; set; }

        public int Preparation_Time { get; set; }

        public ICollection<Image> Images { get; set; } = new HashSet<Image>();
        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
        public ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
        public ICollection<MenuCategoryItem> MenuCategoryItems { get; set; } = new HashSet<MenuCategoryItem>();
        public ICollection<MenuItemPromotion> MenuItemPromotions { get; set; } = new HashSet<MenuItemPromotion>();
    }
}
