namespace Akla.SharedData.Models
{
    public class Promotion : BaseEntity
    {
        [MaxLength(150)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [MaxLength(50)]
        public string DiscountType { get; set; }

        public decimal DiscountValue { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<Image> Images { get; set; } = new HashSet<Image>();
        public virtual ICollection<MenuItemPromotion> MenuItemPromotions { get; set; } = new HashSet<MenuItemPromotion>();
    }
}
