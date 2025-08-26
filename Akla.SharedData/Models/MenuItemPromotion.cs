namespace Akla.SharedData.Models
{
    public class MenuItemPromotion : BaseEntity
    {
        public long MenuItemId { get; set; }
        public long PromotionId { get; set; }

        public virtual MenuItem MenuItem { get; set; }
        public virtual Promotion Promotion { get; set; }
    }
}
