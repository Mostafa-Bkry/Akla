using System.ComponentModel.DataAnnotations;

namespace Akla.SharedData.Models
{
    public class RestaurantTable : BaseEntity
    {
        [MaxLength(20)]
        public string TableNumber { get; set; }

        public int Capacity { get; set; }

        [MaxLength(20)]
        public string LocationZone { get; set; }

        public bool IsAvailable { get; set; }
    }
}
