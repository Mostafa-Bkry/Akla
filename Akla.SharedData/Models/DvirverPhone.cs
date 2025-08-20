namespace Akla.SharedData.Models
{
    public class DvirverPhone : Phone
    {
        public long Driver_Id { get; set; }
        public virtual Driver Driver { get; set; }
    }
}
