namespace Akla.SharedData.Models
{
    public class MenuItemPromotion
    {
        public long MenuItem_Id { get; set; }
        public long Promotion_Id { get; set; }

        public MenuItem MenuItem { get; set; }
        public Promotion Promotion { get; set; }
    }
}
