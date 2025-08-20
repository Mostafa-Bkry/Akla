namespace Akla.SharedData.Models
{
    public class Driver : BaseEntity
    {
        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Vehicle_Type { get; set; }

        [MaxLength(20)]
        public string License_Plate { get; set; }

        [MaxLength(20)]
        public string PrimaryPhoneNumber { get; set; }

        public ICollection<DvirverPhone> PhoneNumbers { get; set; } = new HashSet<DvirverPhone>();
        public ICollection<Delivery> Deliveries { get; set; } = new HashSet<Delivery>();
    }
}
