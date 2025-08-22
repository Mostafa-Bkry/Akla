namespace Akla.SharedData.Models
{
    public class MenuItemPromotion : BaseEntity
    {
        public long MenuItem_Id { get; set; }
        public long Promotion_Id { get; set; }

        public virtual MenuItem MenuItem { get; set; }
        public virtual Promotion Promotion { get; set; }
    }
}
