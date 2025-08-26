namespace Akla.SharedData.Models
{
    public class Image : BaseEntity
    {
        [MaxLength(255)]
        public string ImageUrl { get; set; }

        public long MenuItemId { get; set; }
        public long PromotionId { get; set; }

        public virtual MenuItem MenuItem { get; set; }
        public virtual Promotion Promotion { get; set; }
    }
}
