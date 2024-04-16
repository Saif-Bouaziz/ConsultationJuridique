namespace ConsultationAvocat.Models
{
    public class AvocatAvailability
    {
        public int Id { get; set; }
        public string? AvocatId { get; set; } 

        public string AvocatName { get; set; }


        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

       
    }
}
