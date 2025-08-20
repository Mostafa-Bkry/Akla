namespace Akla.SharedData.Models
{
    public class CustomerPhone : Phone
    {
        public long Customer_Id { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
