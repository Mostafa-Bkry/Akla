namespace Akla.SharedData.Models
{
    public class Customer : BaseEntity
    {
        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string Email { get; set; }

        [MaxLength(255)]
        public string PasswordHashed { get; set; }

        public DateTime Join_Date { get; set; }

        public long PaymentMehod_Id { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
        public ICollection<CustomerPhone> PhoneNumbers { get; set; } = new HashSet<CustomerPhone>();
        public virtual ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
        public Review? Review { get; set; }
        public ICollection<Reservation> Reservations { get; set; } = new HashSet<Reservation>();
    }
}
