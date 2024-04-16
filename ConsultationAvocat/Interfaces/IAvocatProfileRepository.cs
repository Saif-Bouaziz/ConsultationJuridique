using ConsultationAvocat.Models.ConsultationAvocat.Models;

namespace ConsultationAvocat.Interfaces
{
    public interface IAvocatProfileRepository
    {
        Task<bool> CreateAsync(Profile profile);
        Task<Profile> GetProfileByEmailAsync(string email);
    }
}
