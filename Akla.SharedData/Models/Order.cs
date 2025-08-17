using System.ComponentModel.DataAnnotations;

namespace Akla.SharedData.Models
{
    public class Order : BaseEntity
    {
        public DateTime Order_Time { get; set; }
        public decimal Total_Amount { get; set; }
        public int Status { get; set; }

        [MaxLength(255)]
        public string Delivery_Address { get; set; }

        public int Payment_Method_Id { get; set; }

        public Customer Customer { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
    }
}
