namespace Akla.SharedData.Models
{
    public class MenuCategoryItem : BaseEntity
    {
        public long MenuCategoryId { get; set; }
        public long MenuItemId { get; set; }

        public virtual MenuItem MenuItem { get; set; }
        public virtual MenuCategory MenuCategory { get; set; }
    }
}
