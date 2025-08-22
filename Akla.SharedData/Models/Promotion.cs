using System.ComponentModel.DataAnnotations;

namespace Akla.SharedData.Models
{
    public class Promotion : BaseEntity
    {
        [MaxLength(150)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [MaxLength(50)]
        public string Discount_Type { get; set; }

        public decimal Discount_Value { get; set; }

        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }

        public virtual ICollection<Image> Images { get; set; } = new HashSet<Image>();
        public virtual ICollection<MenuItemPromotion> MenuItemPromotions { get; set; } = new HashSet<MenuItemPromotion>();
    }
}
