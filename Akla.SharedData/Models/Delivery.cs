using System.ComponentModel.DataAnnotations;

namespace Akla.SharedData.Models
{
    public class Delivery : BaseEntity
    {
        public DateTime Delivery_Time { get; set; }

        public DateTime Dispath_Time { get; set; }

        [MaxLength(20)]
        public string Status { get; set; }

        public long Driver_Id { get; set; }
        public long Order_Id { get; set; }
    }
}
