namespace Akla.SharedData.Models
{
    public class PaymentMethod : BaseEntity
    {
        [MaxLength(10)]
        public string Method_Name { get; set; }

        public ICollection<Customer> Customers { get; set; } = new HashSet<Customer>();
    }
}
