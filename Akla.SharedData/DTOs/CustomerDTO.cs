namespace Akla.SharedData.DTOs
{
    public class CustomerDTO
    {
        public long Id { get; set; }

        [MaxLength(150)]
        public string Name { get; set; }

        public DateTime JoinDate { get; set; }

        public List<string> PhoneNumbers { get; set; }
    }
}
