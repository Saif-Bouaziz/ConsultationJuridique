using ConsultationAvocat.Interfaces;
using ConsultationAvocat.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace ConsultationAvocat.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IAvocatProfileRepository _avocatProfile;
        private readonly ApplicationDbContext _dbContext; 

        public ClientController(UserManager<IdentityUser> userManager, IAvocatProfileRepository avocatProfile, ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _avocatProfile = avocatProfile;
            _dbContext = dbContext;
        }

        [HttpGet("GetAvocatProfiles")]
        
        public async Task<IActionResult> GetAvocatProfiles()
        {
            var avocats = await _userManager.GetUsersInRoleAsync("Avocat");

            var profileViewModels = new List<ProfileViewModel>();

            foreach (var avocat in avocats)
            {
                var profile = await _avocatProfile.GetProfileByEmailAsync(avocat.Email);
                if (profile != null)
                {
                    var profileViewModel = new ProfileViewModel
                    {
                        Name = profile.UserName,
                        Email = profile.Email,
                        Address = profile.Address,
                        Tel = profile.Telephone,
                        Exp = profile.Experience,
                        Tarif = profile.Tariffs,
                        
                    };

                    profileViewModels.Add(profileViewModel);
                }
            }

            return Ok(profileViewModels);
        }



        [HttpGet("GetListAvailibility")]

        public async Task<ActionResult<IEnumerable<AvocatAvailability>>> GetDisponibilities()
        {
            return  await _dbContext.AvocatAvailabilities.ToListAsync();
        }

        [HttpPost("PrendreRendezVous")]

        public async Task<IActionResult> Create(string avocatId, DateTime appointmentDateTime)
        {

            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var client = await _userManager.FindByIdAsync(userId);
            
       
            
            var avocat = await _userManager.FindByIdAsync(avocatId.ToString());

            if (client == null || avocat == null)
            {
                return NotFound();
            }

            var appointment = new RendezVous
            {
                AppointmentTime = appointmentDateTime,
                ClientId = userId,
                ClientName= client.UserName,
                AvocatId = avocatId.ToString(),
                AvocatName = avocat.UserName 
                
            };

            _dbContext.Appointments.Add(appointment);
            await _dbContext.SaveChangesAsync();

            return Ok(appointment);
        }
    }
}
