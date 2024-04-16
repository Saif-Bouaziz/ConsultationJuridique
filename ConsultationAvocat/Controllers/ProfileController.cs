using ConsultationAvocat.Interfaces;
using ConsultationAvocat.Models;
using ConsultationAvocat.Models.ConsultationAvocat.Models;
using ConsultationAvocat.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ConsultationAvocat.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IAvocatProfileRepository _avocatProfileRepository;
        private readonly IAvocatAvailabilityService _avocatAvailabilityService;
        private readonly UserManager<IdentityUser> _userManager;

        public ProfileController(ApplicationDbContext context, IAvocatProfileRepository avocatProfileRepository, IAvocatAvailabilityService avocatAvailability , UserManager<IdentityUser> userManager)
        {
            _context = context;
            _avocatProfileRepository = avocatProfileRepository;
            _avocatAvailabilityService = avocatAvailability;
            _userManager = userManager;
            
        }

        [HttpPost("CreateProfileAvocat")]
        public async Task<bool> Create(Profile profile)
        {
            
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);   
            profile.UserId = userId;
            var user = await _userManager.FindByIdAsync(userId);
            string userName = user.UserName;
            profile.UserName = userName;
            await _avocatProfileRepository.CreateAsync(profile);
            return true;
        }

        [HttpPost("AddAvailabilityAvocat")]
        public async Task<bool> AddAvailability(AvocatAvailability availability)
        {
            
            string avocatId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            availability.AvocatId = avocatId;
            var user = await _userManager.FindByIdAsync(avocatId);
            string userName = user.UserName;
            availability.AvocatName = userName;

            await _avocatAvailabilityService.AddAvailability(availability);

            return true;
        }

    }

}
