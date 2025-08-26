namespace Akla.SharedData.Models
{
    public class CustomerPhone : Phone
    {
        public long CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
