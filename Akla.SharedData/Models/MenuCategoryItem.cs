namespace Akla.SharedData.Models
{
    public class MenuCategoryItem : BaseEntity
    {
        public long MenuCategory_Id { get; set; }
        public long MenuItem_Id { get; set; }

        public virtual MenuItem MenuItem { get; set; }
        public virtual MenuCategory MenuCategory { get; set; }
    }
}
