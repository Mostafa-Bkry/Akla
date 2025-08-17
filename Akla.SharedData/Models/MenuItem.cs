using System.ComponentModel.DataAnnotations;

namespace Akla.SharedData.Models
{
    public class MenuItem : BaseEntity
    {
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        public decimal Price { get; set; }

        public bool Available { get; set; }

        public int Preparation_Time { get; set; }

        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
    }
}
