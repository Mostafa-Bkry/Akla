using System.ComponentModel.DataAnnotations;

namespace Akla.SharedData.Models
{
    public class Order : BaseEntity
    {
        public DateTime Order_Time { get; set; }
        public decimal Total_Amount { get; set; }

        [MaxLength(20)]
        public string Status { get; set; }

        [MaxLength(255)]
        public string Delivery_Address { get; set; }

        public int Payment_Method_Id { get; set; }
    }
}
