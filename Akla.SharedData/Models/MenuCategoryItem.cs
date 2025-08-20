namespace Akla.SharedData.Models
{
    public class MenuCategoryItem
    {
        public long MenuCategory_Id { get; set; }
        public long MenuItem_Id { get; set; }

        public MenuItem MenuItem { get; set; }
        public MenuCategory MenuCategory { get; set; }
    }
}
