using System.ComponentModel.DataAnnotations;

namespace Akla.SharedData.Models
{
    public class Reservation : BaseEntity
    {
        public DateTime Reservatoin_Time { get; set; }

        public int Party_Size { get; set; }

        [MaxLength(20)]
        public string Status { get; set; }

        [MaxLength(500)]
        public string Special_Requests { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual RestaurantTable RestaurantTable { get; set; }
    }
}
