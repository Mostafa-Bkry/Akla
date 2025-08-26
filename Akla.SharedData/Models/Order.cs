namespace Akla.SharedData.Models
{
    public class Order : BaseEntity
    {
        public DateTime OrderTime { get; set; }
        public decimal TotalAmount { get; set; }
        public int Status { get; set; }

        [MaxLength(255)]
        public string DeliveryAddress { get; set; }

        public long PaymentMethodId { get; set; }
        public long CustomerId { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
        public virtual Delivery? Delivery { get; set; }
    }
}
