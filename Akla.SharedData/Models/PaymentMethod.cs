namespace Akla.SharedData.Models
{
    public class PaymentMethod : BaseEntity
    {
        [MaxLength(10)]
        public string MethodName { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
