namespace Akla.SharedData.Models
{
    public class OrderItem : BaseEntity
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        [MaxLength(255)]
        public string SpecialInstructions { get; set; }

        public long MenuItemId { get; set; }
        public long OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual MenuItem MenuItem { get; set; }
    }
}
