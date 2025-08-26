namespace Akla.SharedData.Models
{
    public class Reservation : BaseEntity
    {
        public DateTime ReservatoinTime { get; set; }

        public int PartySize { get; set; }

        [MaxLength(20)]
        public string Status { get; set; }

        [MaxLength(500)]
        public string SpecialRequests { get; set; }

        public long RestaurantTableId { get; set; }
        public long CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual RestaurantTable RestaurantTable { get; set; }
    }
}
