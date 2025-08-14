using System.ComponentModel.DataAnnotations;

namespace Akla.SharedData.Models
{
    public class Driver : BaseEntity
    {
        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(50)]
        public string Vehicle_Type { get; set; }

        [MaxLength(20)]
        public string License_Plate { get; set; }
    }
}
