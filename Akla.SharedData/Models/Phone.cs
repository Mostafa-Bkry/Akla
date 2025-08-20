namespace Akla.SharedData.Models
{
    public class Phone : BaseEntity
    {
        [MaxLength(20)]
        public string Phone_Number { get; set; }
    }
}
