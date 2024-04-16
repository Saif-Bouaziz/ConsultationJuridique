using ConsultationAvocat.Interfaces;
using ConsultationAvocat.Models;
using ConsultationAvocat.Models.ConsultationAvocat.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsultationAvocat.Repository
{
    public class AvocatProfileRepository : IAvocatProfileRepository
    {
        private readonly ApplicationDbContext _context;

        public AvocatProfileRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(Profile profile)
        {
            _context.Profiles.Add(profile);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<Profile> GetProfileByEmailAsync(string email)
        {
            return await _context.Profiles.FirstOrDefaultAsync(p => p.Email == email);
        }

    }
}
