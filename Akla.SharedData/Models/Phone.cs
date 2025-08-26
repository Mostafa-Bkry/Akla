namespace Akla.SharedData.Models
{
    public class Phone : BaseEntity
    {
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
    }
}
