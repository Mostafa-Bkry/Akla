namespace Akla.SharedData.Models
{
    public class Image : BaseEntity
    {
        [MaxLength(255)]
        public string Image_Url { get; set; }

        public long MenuItem_Id { get; set; }
        public long Promotion_Id { get; set; }

        public virtual MenuItem MenuItem { get; set; }
        public virtual Promotion Promotion { get; set; }
    }
}
