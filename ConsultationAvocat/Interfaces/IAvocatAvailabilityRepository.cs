using ConsultationAvocat.Models;

namespace ConsultationAvocat.Repository
{
    public interface IAvocatAvailabilityService
    {
        Task<bool> AddAvailability(AvocatAvailability availability);
    }
}
