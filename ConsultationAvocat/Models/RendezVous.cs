using ConsultationAvocat.Models.ConsultationAvocat.Models;

namespace ConsultationAvocat.Models
{
    public class RendezVous
    {
        public int Id { get; set; }
        public string? ClientId { get; set; }
        public string ClientName { get; set; }

        
        public string AvocatName { get; set; }
        public string AvocatId { get; set; }

        public DateTime AppointmentTime { get; set; }
        
    }
}
