namespace Akla.SharedData.Models
{
    public class OrderItem : BaseEntity
    {
        public int Quantity { get; set; }
        public decimal Unit_Price { get; set; }

        [MaxLength(255)]
        public string Special_Instructions { get; set; }

        public long MenuItem_Id { get; set; }
        public long Order_Id { get; set; }

        public virtual Order Order { get; set; }
        public virtual MenuItem MenuItem { get; set; }
    }
}
