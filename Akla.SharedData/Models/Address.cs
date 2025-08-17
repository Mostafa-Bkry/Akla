using System.ComponentModel.DataAnnotations;

namespace Akla.SharedData.Models
{
    public class Address : BaseEntity
    {
        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(150)]
        public string Street { get; set; }

        public long Customer_Id { get; set; }
    }
}
