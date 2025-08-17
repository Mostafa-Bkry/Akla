using System.ComponentModel.DataAnnotations;

namespace Akla.SharedData.Models
{
    public class Review : BaseEntity
    {
        [Range(0, 10)]
        public int Rating { get; set; }

        [MaxLength(500)]
        public string? Comment { get; set; }

        public DateTime Review_Date { get; set; }

        public long Customer_Id { get; set; }
        public long MenuItem_Id { get; set; }

        public Customer Customer { get; set; }
    }
}
