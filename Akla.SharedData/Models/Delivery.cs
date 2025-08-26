namespace Akla.SharedData.Models
{
    public class Delivery : BaseEntity
    {
        public DateTime DeliveryTime { get; set; }

        public DateTime DispathTime { get; set; }

        [MaxLength(20)]
        public string Status { get; set; }

        public long DriverId { get; set; }
        public long OrderId { get; set; }

        public virtual Driver Driver { get; set; }
        public virtual Order Order { get; set; }
    }
}
