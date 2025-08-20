using System.ComponentModel.DataAnnotations;

namespace Akla.SharedData.Models
{
    public class MenuCategory : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }

        [Range(1, int.MaxValue)]
        public int Ordering { get; set; }

        public virtual ICollection<MenuCategoryItem> MenuCategoryItems { get; set; } = new HashSet<MenuCategoryItem>();
    }
}
