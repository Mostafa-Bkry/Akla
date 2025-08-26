namespace Akla.SharedData.Models
{
    public class Driver : BaseEntity
    {
        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string VehicleType { get; set; }

        [MaxLength(20)]
        public string LicensePlate { get; set; }

        [MaxLength(20)]
        public string PrimaryPhoneNumber { get; set; }

        public virtual ICollection<DriverPhone> PhoneNumbers { get; set; } = new HashSet<DriverPhone>();
        public virtual ICollection<Delivery> Deliveries { get; set; } = new HashSet<Delivery>();
    }
}
