namespace Akla.SharedData.Models
{
    public class Customer : BaseEntity
    {
        [MaxLength(150)]
        public string Name { get; set; }

        //[MaxLength(150)]
        //public string Email { get; set; }

        //[MaxLength(255)]
        //public string PasswordHashed { get; set; }

        public DateTime JoinDate { get; set; }

        public virtual ICollection<CustomerPhone> PhoneNumbers { get; set; } = new HashSet<CustomerPhone>();
        public virtual ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
        public virtual Review? Review { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; } = new HashSet<Reservation>();
    }
}
