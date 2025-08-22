namespace Akla.SharedData.Models
{
    public class Order : BaseEntity
    {
        public DateTime Order_Time { get; set; }
        public decimal Total_Amount { get; set; }
        public int Status { get; set; }

        [MaxLength(255)]
        public string Delivery_Address { get; set; }

        public long PaymentMethod_Id { get; set; }
        public long Customer_Id { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
        public virtual Delivery? Delivery { get; set; }
    }
}
