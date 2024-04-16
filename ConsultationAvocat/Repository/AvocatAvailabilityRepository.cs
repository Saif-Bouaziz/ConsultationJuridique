using ConsultationAvocat.Models;

namespace ConsultationAvocat.Repository
{
    public class AvocatAvailabilityService : IAvocatAvailabilityService
    {
        private readonly ApplicationDbContext _context;

        public AvocatAvailabilityService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddAvailability(AvocatAvailability availability)
        {
            _context.AvocatAvailabilities.Add(availability);
            await _context.SaveChangesAsync();
            return true;
        }
        
    }
}
