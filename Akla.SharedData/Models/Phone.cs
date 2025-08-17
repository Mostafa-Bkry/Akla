using System.ComponentModel.DataAnnotations;

namespace Akla.SharedData.Models
{
    public class Phone : BaseEntity
    {
        [MaxLength(20)]
        public string Phone_Number { get; set; }

        public long Customer_Id { get; set; }
        public long Driver_Id { get; set; }
    }
}
