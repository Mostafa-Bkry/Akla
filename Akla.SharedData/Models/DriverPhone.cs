namespace Akla.SharedData.Models
{
    public class DriverPhone : Phone
    {
        public long DriverId { get; set; }
        public virtual Driver Driver { get; set; }
    }
}
