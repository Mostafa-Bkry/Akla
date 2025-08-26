namespace Akla.SharedData.Models
{
    public class Review : BaseEntity
    {
        [Range(0, 10)]
        public int Rating { get; set; }

        [MaxLength(500)]
        public string? Comment { get; set; }

        public DateTime ReviewDate { get; set; }

        public long CustomerId { get; set; }
        public long MenuItemId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual MenuItem MenuItem { get; set; }
    }
}
